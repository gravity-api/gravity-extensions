/*
 * CHANGE LOG - keep only last 5 threads
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Gravity.Extensions
{
    /// <summary>
    /// Utilities class for various tasks and simplification of complicated operations.
    /// </summary>
    public static class Utilities
    {
        #region *** Get Types  ***
        /// <summary>
        /// Gets a collection of <see cref="Type"/> from all assemblies where the executing assembly is currently located.
        /// </summary>
        /// <returns>A collection of <see cref="Type"/>.</returns>
        public static IEnumerable<Type> GetTypes()
        {
            // get all referenced assemblies
            var referenced = GetReferencedAssemblies();
            var attached = GetAttachedAssemblies(referenced);

            // build assemblies list
            var assemblies = new List<Assembly>();
            assemblies.AddRange(referenced);
            assemblies.AddRange(attached);

            // load all sub-references
            var subReferences = new List<Assembly>();
            foreach (var a in assemblies)
            {
                try
                {
                    var r = a.GetReferencedAssemblies();
                    subReferences.AddRange(r.Select(Assembly.Load));
                }
                catch (Exception e) when (e != null)
                {
                    // ignore failed assemblies
                }
            }
            assemblies.AddRange(subReferences);

            // load all assemblies excluding the executing assembly
            var types = new List<Type>();
            foreach (var a in assemblies.Distinct())
            {
                try
                {
                    types.AddRange(a.GetTypes());
                }
                catch (Exception e) when (e != null)
                {
                    // ignore failed assemblies
                }
            }
            return types;
        }

        // loads all referenced assemblies from: executing, calling & entry
        private static IEnumerable<Assembly> GetReferencedAssemblies()
        {
            // shortcuts
            var executing = Assembly.GetExecutingAssembly();
            var calling = Assembly.GetCallingAssembly();
            var entry = Assembly.GetEntryAssembly();

            // initialize results collection
            var assemblies = new List<Assembly> { executing, calling, entry }.Where(r => r != null).ToList();
            var referenced = new List<AssemblyName>
            {
                executing.GetName(),
                calling.GetName(),
                entry?.GetName()
            }
            .Where(r => r != null).ToList();

            // cache all assemblies references
            referenced.TryAddRange(executing?.GetReferencedAssemblies());
            referenced.TryAddRange(calling?.GetReferencedAssemblies());
            referenced.TryAddRange(entry?.GetReferencedAssemblies());

            // load assemblies            
            assemblies.AddRange(referenced.Select(Assembly.Load));
            return assemblies;
        }

        // loads all attached assemblies from current & working directories
        private static IEnumerable<Assembly> GetAttachedAssemblies(IEnumerable<Assembly> referenced)
        {
            // short-cuts
            var working = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var current = Environment.CurrentDirectory;

            // get all referenced names
            var referencedNames = referenced.Select(r => $"{working}\\{r.GetName().Name}.dll");

            // load assemblies
            var w = Directory.GetFiles(working).Where(f => f.EndsWith(".dll") && !referencedNames.Contains(f));
            var c = Directory.GetFiles(current).Where(f => f.EndsWith(".dll") && !referencedNames.Contains(f));

            // build names
            var attachedAssembliesNames = new List<string>();
            attachedAssembliesNames.TryAddRange(w);
            attachedAssembliesNames.TryAddRange(c);

            // build results
            var loadedAssemblies = new List<Assembly>();
            foreach (var a in attachedAssembliesNames)
            {
                try
                {
                    var name = AssemblyName.GetAssemblyName(a);
                    var range = Assembly.Load(name);
                    loadedAssemblies.Add(range);
                }
                catch (Exception e) when (e != null)
                {
                    // ignore failed assemblies
                }
            }
            return loadedAssemblies;
        }
        #endregion

        #region *** Copy Files ***
        /// <summary>
        /// Copy a folder from source location into target location.
        /// </summary>
        /// <param name="sourceDirectory">Source directory to copy.</param>
        /// <param name="targetDirectory">Target directory to copy.</param>
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            // setup
            var source = new DirectoryInfo(sourceDirectory);
            var target = new DirectoryInfo(targetDirectory);

            // copy
            DoCopyAll(source, target);
        }

        /// <summary>
        /// copy folder from source into target
        /// </summary>
        /// <param name="source">source directory to copy</param>
        /// <param name="target">target directory to copy</param>
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            DoCopyAll(source, target);
        }

        private static void DoCopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // copy each file into the new directory.
            foreach (FileInfo f in source.GetFiles())
            {
                f.CopyTo(Path.Combine(target.FullName, f.Name), true);
            }

            // copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                DoCopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        #endregion

        /// <summary>
        /// Gets <see cref="JsonSerializerSettings"/> based on <see cref="NamingStrategy"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="NamingStrategy"/> strategy type.</typeparam>
        /// <returns>The <see cref="JsonSerializerSettings"/> applied on a <see cref="JsonSerializer"/> object.</returns>
        public static JsonSerializerSettings GetJsonSettings<T>(Formatting formatting = Formatting.Indented) where T : NamingStrategy, new()
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new T()
            };
            return new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = formatting
            };
        }
    }
}