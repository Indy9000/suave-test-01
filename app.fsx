#r "packages/Suave/lib/net40/Suave.dll"
open Suave
open Suave.Http.Successful
open Suave.Web
open Suave.Types
open System.IO
open System

open Suave.Http
open Suave.Http.Applicatives
open Suave.Http.Successful // for OK-result
open Suave.Http.ServerErrors
open Suave.Http.RequestErrors
open Suave.Http.Files     

open Suave.Web             // for config
open Suave.Types
open Suave.Logging

let app : WebPart = 
    choose [
       GET >>= choose [ path "/" >>= file "index.html"; browseHome ];
       NOT_FOUND "Found no handlers." 
    ]
