// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The note acl link type object</para>
    /// </summary>
    public class NoteAclLinkType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<NoteAclLinkType> Encoder = new NoteAclLinkTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<NoteAclLinkType> Decoder = new NoteAclLinkTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NoteAclLinkType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public NoteAclLinkType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NoteAclLinkType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public NoteAclLinkType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the note acl link type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="NoteAclLinkType" />.</para>
        /// </summary>
        private class NoteAclLinkTypeEncoder : enc.StructEncoder<NoteAclLinkType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(NoteAclLinkType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="NoteAclLinkType" />.</para>
        /// </summary>
        private class NoteAclLinkTypeDecoder : enc.StructDecoder<NoteAclLinkType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="NoteAclLinkType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override NoteAclLinkType Create()
            {
                return new NoteAclLinkType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(NoteAclLinkType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}