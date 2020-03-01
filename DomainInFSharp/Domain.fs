namespace FSharpDomain

open System

module Model =

    type Person = {
        Name: string
        Birthday: DateTime
    }

    open FSharp.Json
    let personToJson (p: Person) =
        Json.serialize p

