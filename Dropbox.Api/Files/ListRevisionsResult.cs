// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The list revisions result object</para>
    /// </summary>
    public class ListRevisionsResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListRevisionsResult> Encoder = new ListRevisionsResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListRevisionsResult> Decoder = new ListRevisionsResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsResult" />
        /// class.</para>
        /// </summary>
        /// <param name="isDeleted">If the file is deleted.</param>
        /// <param name="entries">The revisions for the file. Only non-delete revisions will
        /// show up here.</param>
        public ListRevisionsResult(bool isDeleted,
                                   col.IEnumerable<FileMetadata> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.IsDeleted = isDeleted;
            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListRevisionsResult()
        {
        }

        /// <summary>
        /// <para>If the file is deleted.</para>
        /// </summary>
        public bool IsDeleted { get; protected set; }

        /// <summary>
        /// <para>The revisions for the file. Only non-delete revisions will show up
        /// here.</para>
        /// </summary>
        public col.IList<FileMetadata> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListRevisionsResult" />.</para>
        /// </summary>
        private class ListRevisionsResultEncoder : enc.StructEncoder<ListRevisionsResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListRevisionsResult value, enc.IJsonWriter writer)
            {
                WriteProperty("is_deleted", value.IsDeleted, writer, enc.BooleanEncoder.Instance);
                WriteListProperty("entries", value.Entries, writer, Dropbox.Api.Files.FileMetadata.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListRevisionsResult" />.</para>
        /// </summary>
        private class ListRevisionsResultDecoder : enc.StructDecoder<ListRevisionsResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListRevisionsResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListRevisionsResult Create()
            {
                return new ListRevisionsResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListRevisionsResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "is_deleted":
                        value.IsDeleted = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "entries":
                        value.Entries = ReadList<FileMetadata>(reader, Dropbox.Api.Files.FileMetadata.Decoder);
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