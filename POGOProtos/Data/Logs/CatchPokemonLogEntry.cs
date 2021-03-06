// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Logs/CatchPokemonLogEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs
{

    /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/CatchPokemonLogEntry.proto</summary>
    public static partial class CatchPokemonLogEntryReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Data/Logs/CatchPokemonLogEntry.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static CatchPokemonLogEntryReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Ci9QT0dPUHJvdG9zL0RhdGEvTG9ncy9DYXRjaFBva2Vtb25Mb2dFbnRyeS5w",
                  "cm90bxIUUE9HT1Byb3Rvcy5EYXRhLkxvZ3MaIFBPR09Qcm90b3MvRW51bXMv",
                  "UG9rZW1vbklkLnByb3RvIowCChRDYXRjaFBva2Vtb25Mb2dFbnRyeRJBCgZy",
                  "ZXN1bHQYASABKA4yMS5QT0dPUHJvdG9zLkRhdGEuTG9ncy5DYXRjaFBva2Vt",
                  "b25Mb2dFbnRyeS5SZXN1bHQSLwoKcG9rZW1vbl9pZBgCIAEoDjIbLlBPR09Q",
                  "cm90b3MuRW51bXMuUG9rZW1vbklkEhUKDWNvbWJhdF9wb2ludHMYAyABKAUS",
                  "FwoPcG9rZW1vbl9kYXRhX2lkGAQgASgGIlAKBlJlc3VsdBIJCgVVTlNFVBAA",
                  "EhQKEFBPS0VNT05fQ0FQVFVSRUQQARIQCgxQT0tFTU9OX0ZMRUQQAhITCg9Q",
                  "T0tFTU9OX0hBVENIRUQQA2IGcHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.CatchPokemonLogEntry), global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Parser, new[]{ "Result", "PokemonId", "CombatPoints", "PokemonDataId" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result) }, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class CatchPokemonLogEntry : pb::IMessage<CatchPokemonLogEntry>
    {
        private static readonly pb::MessageParser<CatchPokemonLogEntry> _parser = new pb::MessageParser<CatchPokemonLogEntry>(() => new CatchPokemonLogEntry());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CatchPokemonLogEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Data.Logs.CatchPokemonLogEntryReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CatchPokemonLogEntry()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CatchPokemonLogEntry(CatchPokemonLogEntry other) : this()
        {
            result_ = other.result_;
            pokemonId_ = other.pokemonId_;
            combatPoints_ = other.combatPoints_;
            pokemonDataId_ = other.pokemonDataId_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CatchPokemonLogEntry Clone()
        {
            return new CatchPokemonLogEntry(this);
        }

        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;
        private global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result result_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result Result
        {
            get { return result_; }
            set
            {
                result_ = value;
            }
        }

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 2;
        private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Enums.PokemonId PokemonId
        {
            get { return pokemonId_; }
            set
            {
                pokemonId_ = value;
            }
        }

        /// <summary>Field number for the "combat_points" field.</summary>
        public const int CombatPointsFieldNumber = 3;
        private int combatPoints_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CombatPoints
        {
            get { return combatPoints_; }
            set
            {
                combatPoints_ = value;
            }
        }

        /// <summary>Field number for the "pokemon_data_id" field.</summary>
        public const int PokemonDataIdFieldNumber = 4;
        private ulong pokemonDataId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong PokemonDataId
        {
            get { return pokemonDataId_; }
            set
            {
                pokemonDataId_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as CatchPokemonLogEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CatchPokemonLogEntry other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (PokemonId != other.PokemonId) return false;
            if (CombatPoints != other.CombatPoints) return false;
            if (PokemonDataId != other.PokemonDataId) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
            if (CombatPoints != 0) hash ^= CombatPoints.GetHashCode();
            if (PokemonDataId != 0UL) hash ^= PokemonDataId.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Result);
            }
            if (PokemonId != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)PokemonId);
            }
            if (CombatPoints != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(CombatPoints);
            }
            if (PokemonDataId != 0UL)
            {
                output.WriteRawTag(33);
                output.WriteFixed64(PokemonDataId);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
            }
            if (PokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
            }
            if (CombatPoints != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(CombatPoints);
            }
            if (PokemonDataId != 0UL)
            {
                size += 1 + 8;
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CatchPokemonLogEntry other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            if (other.PokemonId != 0)
            {
                PokemonId = other.PokemonId;
            }
            if (other.CombatPoints != 0)
            {
                CombatPoints = other.CombatPoints;
            }
            if (other.PokemonDataId != 0UL)
            {
                PokemonDataId = other.PokemonDataId;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            result_ = (global::POGOProtos.Data.Logs.CatchPokemonLogEntry.Types.Result)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            pokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            CombatPoints = input.ReadInt32();
                            break;
                        }
                    case 33:
                        {
                            PokemonDataId = input.ReadFixed64();
                            break;
                        }
                }
            }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the CatchPokemonLogEntry message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types
        {
            public enum Result
            {
                [pbr::OriginalName("UNSET")]
                Unset = 0,
                [pbr::OriginalName("POKEMON_CAPTURED")]
                PokemonCaptured = 1,
                [pbr::OriginalName("POKEMON_FLED")]
                PokemonFled = 2,
                [pbr::OriginalName("POKEMON_HATCHED")]
                PokemonHatched = 3,
            }

        }
        #endregion

    }

    #endregion

}

#endregion Designer generated code