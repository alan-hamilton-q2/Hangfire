using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if NETFULL
[assembly: AssemblyTitle("Hangfire")]
#endif
[assembly: AssemblyDescription("Core classes of Hangfire that are independent of any framework.")]
[assembly: Guid("4deecd4f-19f6-426b-aa87-6cd1a03eaa48")]
[assembly: CLSCompliant(true)]
[assembly: InternalsVisibleTo("Hangfire.Core.Tests")]

// Allow the generation of mocks for internal types
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]