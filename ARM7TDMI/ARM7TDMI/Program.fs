﻿namespace ARM7TDMI

module Program =

    open MachineState
    open Instructions
    open Tokeniser
    open AST
    open Parser
    open MemoryInstructions
    open InstructionsInterfaces
    open Expecto

    [<EntryPoint>]
    let main argv =

(*        // Command Line Demo
        let rec commandLineDemo () =
            try 
                printfn "Please type your program (press enter three times in a row to finish):"
                let rec readInput (str:string list) (enterCount:int) =
                    let line = System.Console.ReadLine()
                    if line = "" then
                        if enterCount = 2 then
                            str @ [line]
                        else
                            readInput (str @ [line]) (enterCount+1)
                    else
                        readInput (str @ [line]) 0
                let prog = (readInput [] 0 |> String.concat " \n ")
                printfn "Program is:\n%A" prog
                printfn "\nExecuting program..."
                let result = (prog |> tokenise |> Parse |> buildMemory |> initTMP |> execute)
                printfn "Final Machine State:\n%A" result
            with
                _ -> printfn "Failed to run program." 
            printfn "\n\nWould you like to enter another program? (y/n)"
            let answer = System.Console.ReadLine()
            if answer = "y" then
                commandLineDemo ()
            else
                ()

        commandLineDemo () |> ignore *)

        // Expecto Automated Testing
        runTests defaultConfig (testList "Complete Test" [ testToolbox ; testMemory ; testMachineState ])