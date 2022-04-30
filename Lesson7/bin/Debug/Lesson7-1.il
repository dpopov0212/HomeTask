
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Lesson7
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 63 31 35 66 34 64 31 66 2D 33 33 34 39   // ..$c15f4d1f-3349
                                                                                                  2D 34 33 37 34 2D 62 66 39 37 2D 65 31 36 35 66   // -4374-bf97-e165f
                                                                                                  66 63 65 64 36 31 64 00 00 )                      // fced61d..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Lesson7.exe
// MVID: {7F7647E9-0919-44C0-9FBA-4081C65C88B8}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x076A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lesson7.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       130 (0x82)
    .maxstack  2
    .locals init ([0] string login,
             [1] string password,
             [2] int32 count,
             [3] string checkLogin,
             [4] string checkPassword,
             [5] bool V_5,
             [6] bool V_6)
    IL_0000:  nop
    IL_0001:  ldstr      "geek"
    IL_0006:  stloc.0
    IL_0007:  ldstr      "123"
    IL_000c:  stloc.1
    IL_000d:  ldc.i4.0
    IL_000e:  stloc.2
    IL_000f:  nop
    IL_0010:  ldstr      bytearray (0A 00 12 04 32 04 35 04 34 04 38 04 42 04 35 04   // ....2.5.4.8.B.5.
                                    20 00 3B 04 3E 04 33 04 38 04 3D 04 3A 00 20 00 ) //  .;.>.3.8.=.:. .
    IL_0015:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001a:  nop
    IL_001b:  call       string [mscorlib]System.Console::ReadLine()
    IL_0020:  stloc.3
    IL_0021:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 30 04 40 04 3E 04 3B 04 4C 04 3A 00 20 00 ) // ?.0.@.>.;.L.:. .
    IL_0026:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_002b:  nop
    IL_002c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0031:  stloc.s    checkPassword
    IL_0033:  ldloc.0
    IL_0034:  ldloc.3
    IL_0035:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_003a:  brfalse.s  IL_0046

    IL_003c:  ldloc.1
    IL_003d:  ldloc.s    checkPassword
    IL_003f:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_0044:  br.s       IL_0047

    IL_0046:  ldc.i4.0
    IL_0047:  stloc.s    V_5
    IL_0049:  ldloc.s    V_5
    IL_004b:  brtrue.s  IL_0061

    IL_004d:  nop
    IL_004e:  ldstr      bytearray (14 04 3E 04 31 04 40 04 3E 04 20 00 3F 04 3E 04   // ..>.1.@.>. .?.>.
                                    36 04 30 04 3B 04 3E 04 32 04 30 04 42 04 4C 04 ) // 6.0.;.>.2.0.B.L.
    IL_0053:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0058:  nop
    IL_0059:  call       string [mscorlib]System.Console::ReadLine()
    IL_005e:  pop
    IL_005f:  br.s       IL_0081

    IL_0061:  ldstr      bytearray (1D 04 35 04 32 04 35 04 40 04 3D 04 3E 04 20 00   // ..5.2.5.@.=.>. .
                                    32 04 32 04 35 04 34 04 35 04 3D 04 20 00 3B 04   // 2.2.5.4.5.=. .;.
                                    3E 04 33 04 38 04 3D 04 20 00 38 04 3B 04 38 04   // >.3.8.=. .8.;.8.
                                    20 00 3F 04 30 04 40 04 3E 04 3B 04 4C 04 )       //  .?.0.@.>.;.L.
    IL_0066:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_006b:  nop
    IL_006c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0071:  pop
    IL_0072:  ldloc.2
    IL_0073:  ldc.i4.1
    IL_0074:  add
    IL_0075:  stloc.2
    IL_0076:  nop
    IL_0077:  ldloc.2
    IL_0078:  ldc.i4.3
    IL_0079:  clt
    IL_007b:  stloc.s    V_6
    IL_007d:  ldloc.s    V_6
    IL_007f:  brtrue.s   IL_000f

    IL_0081:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Lesson7.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\intel\source\repos\TASK\Lesson7\bin\Debug\Lesson7.res
