﻿namespace Machine 

(* 
	High Level Programming @ Imperial College London # Spring 2017
	Project: A user-friendly ARM7TDMI assembler and simulator in F# and Web Technologies ( Github Electron & Fable Compliler )

	Contributors: Angelos Filos, Baron Khan, Youssef Rizk, Pranav Prabhu

	Module: Common
	Description: 
*)

[<AutoOpen>]
module Common =

    // Raw data type
    type Data = int

    // Register ID D.U
    type RegisterID =
        | R0 | R1 | R2 | R3 | R4
        | R5 | R6 | R7 | R8 | R9
        | R10 | R11 | R12 | R13 | R14 | R15

    // Registers Type Abbreviation
    type Registers = Map<RegisterID, Data>

    // Status Flags ID D.U
    type FlagID =
        | N // Negative Flag
        | Z // Zero Flag
        | C // Carry Flag
        | V // Stack Overflow Flag

    // Flags Type Abbreviation
    type Flags = Map<FlagID, bool>