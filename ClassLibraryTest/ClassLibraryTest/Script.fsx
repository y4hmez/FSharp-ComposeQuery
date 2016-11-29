#load "ClassLibraryTest.fs"
#if INTERACTIVE     // reference required libraries if run as a script
#r @"../../packages/FSharpComposableQuery/lib/net40/FSharpComposableQuery.dll"
#r @"../../packages/FSharp.Data.TypeProviders/lib/net40/FSharp.Data.TypeProviders.dll"
//#r "FSharp.Data.TypeProviders.dll"

#r "System.Data.Linq.dll"

//#r "System.Data.Linq.dll"

#endif


open ClassLibraryTest
open FSharpComposableQuery
open System
open FSharp.Data.TypeProviders


type dbSchema = SqlDataConnection<"Data Source=VMS08;Initial Catalog=MAPS;Integrated Security=SSPI;">
let db = dbSchema.GetDataContext()
db.DataContext.Log <- System.Console.Out


let satisfies = 
    <@ fun p -> query {
       for u in db.TblPerson do 
            if p u.FirstName then
            yield p
    } @>






// let spewDate () = 
    
//     ()
