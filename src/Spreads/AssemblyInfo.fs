﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Spreads")>]
[<assembly: AssemblyProductAttribute("Spreads")>]
[<assembly: AssemblyDescriptionAttribute("Spreads")>]
[<assembly: AssemblyVersionAttribute("0.2.3")>]
[<assembly: AssemblyFileVersionAttribute("0.2.3")>]
[<assembly: AssemblyCopyrightAttribute("(c) Victor Baybekov 2015")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.3"
