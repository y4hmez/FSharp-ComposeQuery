#load "ClassLibraryTest.fs"
#if INTERACTIVE     // reference required libraries if run as a script
#r @"../../packages/FSharpComposableQuery/lib/net40/FSharpComposableQuery.dll"
#r @"../../packages/FSharp.Data.TypeProviders/lib/net40/FSharp.Data.TypeProviders.dll"
#r "System.Data.Linq.dll"

//#r "System.Data.Linq.dll"

#endif


open ClassLibraryTest
open FSharpComposableQuery
