// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The add template arg object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.FileProperties.PropertyGroupTemplate" />
    public class AddTemplateArg : PropertyGroupTemplate
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddTemplateArg> Encoder = new AddTemplateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddTemplateArg> Decoder = new AddTemplateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddTemplateArg" /> class.</para>
        /// </summary>
        /// <param name="name">Display name for the template. Template names can be up to 256
        /// bytes.</param>
        /// <param name="description">Description for the template. Template descriptions can
        /// be up to 1024 bytes.</param>
        /// <param name="fields">Definitions of the property fields associated with this
        /// template. There can be up to 32 properties in a single template.</param>
        public AddTemplateArg(string name,
                              string description,
                              col.IEnumerable<PropertyFieldTemplate> fields)
            : base(name, description, fields)
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddTemplateArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AddTemplateArg()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AddTemplateArg" />.</para>
        /// </summary>
        private class AddTemplateArgEncoder : enc.StructEncoder<AddTemplateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddTemplateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
                WriteListProperty("fields", value.Fields, writer, global::Dropbox.Api.FileProperties.PropertyFieldTemplate.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AddTemplateArg" />.</para>
        /// </summary>
        private class AddTemplateArgDecoder : enc.StructDecoder<AddTemplateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddTemplateArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddTemplateArg Create()
            {
                return new AddTemplateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AddTemplateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "fields":
                        value.Fields = ReadList<PropertyFieldTemplate>(reader, global::Dropbox.Api.FileProperties.PropertyFieldTemplate.Decoder);
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