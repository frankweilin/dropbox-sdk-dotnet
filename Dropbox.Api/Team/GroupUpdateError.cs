// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The group update error object</para>
    /// </summary>
    public class GroupUpdateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupUpdateError> Encoder = new GroupUpdateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupUpdateError> Decoder = new GroupUpdateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupUpdateError" />
        /// class.</para>
        /// </summary>
        public GroupUpdateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// ExternalIdAlreadyInUse</para>
        /// </summary>
        public bool IsExternalIdAlreadyInUse
        {
            get
            {
                return this is ExternalIdAlreadyInUse;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ExternalIdAlreadyInUse, or <c>null</c>.</para>
        /// </summary>
        public ExternalIdAlreadyInUse AsExternalIdAlreadyInUse
        {
            get
            {
                return this as ExternalIdAlreadyInUse;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNotFound</para>
        /// </summary>
        public bool IsGroupNotFound
        {
            get
            {
                return this is GroupNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNotFound, or <c>null</c>.</para>
        /// </summary>
        public GroupNotFound AsGroupNotFound
        {
            get
            {
                return this as GroupNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorEncoder : enc.StructEncoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupUpdateError value, enc.IJsonWriter writer)
            {
                if (value is ExternalIdAlreadyInUse)
                {
                    WriteProperty(".tag", "external_id_already_in_use", writer, enc.StringEncoder.Instance);
                    ExternalIdAlreadyInUse.Encoder.EncodeFields((ExternalIdAlreadyInUse)value, writer);
                    return;
                }
                if (value is GroupNotFound)
                {
                    WriteProperty(".tag", "group_not_found", writer, enc.StringEncoder.Instance);
                    GroupNotFound.Encoder.EncodeFields((GroupNotFound)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorDecoder : enc.UnionDecoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupUpdateError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupUpdateError Create()
            {
                return new GroupUpdateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupUpdateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "external_id_already_in_use":
                        return ExternalIdAlreadyInUse.Decoder.DecodeFields(reader);
                    case "group_not_found":
                        return GroupNotFound.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The new external ID is already being used by another group.</para>
        /// </summary>
        public sealed class ExternalIdAlreadyInUse : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ExternalIdAlreadyInUse> Encoder = new ExternalIdAlreadyInUseEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ExternalIdAlreadyInUse> Decoder = new ExternalIdAlreadyInUseDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ExternalIdAlreadyInUse" />
            /// class.</para>
            /// </summary>
            private ExternalIdAlreadyInUse()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ExternalIdAlreadyInUse</para>
            /// </summary>
            public static readonly ExternalIdAlreadyInUse Instance = new ExternalIdAlreadyInUse();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseEncoder : enc.StructEncoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ExternalIdAlreadyInUse value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseDecoder : enc.StructDecoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ExternalIdAlreadyInUse"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ExternalIdAlreadyInUse Create()
                {
                    return new ExternalIdAlreadyInUse();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ExternalIdAlreadyInUse DecodeFields(enc.IJsonReader reader)
                {
                    return ExternalIdAlreadyInUse.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>No matching group found. No groups match the specified group ID.</para>
        /// </summary>
        public sealed class GroupNotFound : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNotFound> Encoder = new GroupNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNotFound> Decoder = new GroupNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNotFound" />
            /// class.</para>
            /// </summary>
            private GroupNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNotFound</para>
            /// </summary>
            public static readonly GroupNotFound Instance = new GroupNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNotFound" />.</para>
            /// </summary>
            private class GroupNotFoundEncoder : enc.StructEncoder<GroupNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNotFound" />.</para>
            /// </summary>
            private class GroupNotFoundDecoder : enc.StructDecoder<GroupNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNotFound Create()
                {
                    return new GroupNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}