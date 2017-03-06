﻿namespace ARM7TDMI

(* 
    High Level Programming @ Imperial College London # Spring 2017
    Project: A user-friendly ARM7TDMI assembler and simulator in F# and Web Technologies ( Github Electron & Fable Compliler )

    Contributors: Pranav Prabhu

    Module: Parser
    Description: Parse individual instruction and initiate correct function call
*)

module Parser =

    open System
    open Instructions
    open Common

    type FlagSet =
        | Twoflags of bool*bool 
        | Oneflag of bool

    type Expr = 
        | Instruction of string*RegisterID*RegisterID*Operand*FlagSet
        