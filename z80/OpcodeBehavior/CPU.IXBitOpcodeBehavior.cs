using System;

namespace JustinCredible.ZilogZ80
{
    public partial class CPU
    {
        private void ExecuteIXBitOpcode(Opcode opcode, out bool incrementProgramCounter, out bool useAlternateCycleCount)
        {
            incrementProgramCounter = true;
            useAlternateCycleCount = false;

            switch (opcode.Code)
            {
                #region Rotate

                    #region RLC (IX+n), r - Rotate left

                        case OpcodeBytes.RLC_IX_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.B = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.C = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.D = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.E = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.H = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.L = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IX:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            value = ExecuteRotate(value, left: true);
                            WriteMemory(Registers.IX + offset, value);
                            break;
                        }
                        case OpcodeBytes.RLC_IX_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.A = ExecuteRotate(value, left: true);
                            break;
                        }

                    #endregion

                    #region RRC (IX+n), r - Rotate right

                        case OpcodeBytes.RRC_IX_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.B = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.C = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.D = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.E = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.H = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.L = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IX:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            value = ExecuteRotate(value, left: false);
                            WriteMemory(Registers.IX + offset, value);
                            break;
                        }
                        case OpcodeBytes.RRC_IX_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.A = ExecuteRotate(value, left: false);
                            break;
                        }

                    #endregion

                    #region RL (IX+n), r - Rotate left through carry

                        case OpcodeBytes.RL_IX_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.B = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.C = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.D = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.E = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.H = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.L = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IX:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            value = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            WriteMemory(Registers.IX + offset, value);
                            break;
                        }
                        case OpcodeBytes.RL_IX_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.A = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }

                    #endregion

                    #region RR (IX+n), r - Rotate right through carry

                        case OpcodeBytes.RR_IX_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.B = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.C = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.D = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.E = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.H = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.L = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IX:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            value = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            WriteMemory(Registers.IX + offset, value);
                            break;
                        }
                        case OpcodeBytes.RR_IX_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IX + offset);
                            Registers.A = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }

                    #endregion

                #endregion

                default:
                    throw new NotImplementedException(String.Format("Attempted to execute unknown opcode 0x{0:X2} at memory address 0x{1:X4}", opcode, Registers.PC));
            }
        }
    }
}
