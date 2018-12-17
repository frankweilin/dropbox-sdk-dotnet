// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The search arg object</para>
    /// </summary>
    public class SearchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SearchArg> Encoder = new SearchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SearchArg> Decoder = new SearchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SearchArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path in the user's Dropbox to search. Should probably be a
        /// folder.</param>
        /// <param name="query">The string to search for. The search string is split on spaces
        /// into multiple tokens. For file name searching, the last token is used for prefix
        /// matching (i.e. "bat c" matches "bat cave" but not "batman car").</param>
        /// <param name="start">The starting index within the search results (used for
        /// paging).</param>
        /// <param name="maxResults">The maximum number of search results to return.</param>
        /// <param name="mode">The search mode (filename, filename_and_content, or
        /// deleted_filename). Note that searching file content is only available for Dropbox
        /// Business accounts.</param>
        public SearchArg(string path,
                         string query,
                         ulong start = 0,
                         ulong maxResults = 100,
                         SearchMode mode = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*)?|id:.*|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*)?|id:.*|(ns:[0-9]+(/.*)?))\z'");
            }

            if (query == null)
            {
                throw new sys.ArgumentNullException("query");
            }

            if (maxResults < 1UL)
            {
                throw new sys.ArgumentOutOfRangeException("maxResults", "Value should be greater or equal than 1");
            }
            if (maxResults > 1000UL)
            {
                throw new sys.ArgumentOutOfRangeException("maxResults", "Value should be less of equal than 1000");
            }

            if (mode == null)
            {
                mode = global::Dropbox.Api.Files.SearchMode.Filename.Instance;
            }
            this.Path = path;
            this.Query = query;
            this.Start = start;
            this.MaxResults = maxResults;
            this.Mode = mode;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SearchArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SearchArg()
        {
            this.Start = 0;
            this.MaxResults = 100;
            this.Mode = global::Dropbox.Api.Files.SearchMode.Filename.Instance;
        }

        /// <summary>
        /// <para>The path in the user's Dropbox to search. Should probably be a folder.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>The string to search for. The search string is split on spaces into multiple
        /// tokens. For file name searching, the last token is used for prefix matching (i.e.
        /// "bat c" matches "bat cave" but not "batman car").</para>
        /// </summary>
        public string Query { get; protected set; }

        /// <summary>
        /// <para>The starting index within the search results (used for paging).</para>
        /// </summary>
        public ulong Start { get; protected set; }

        /// <summary>
        /// <para>The maximum number of search results to return.</para>
        /// </summary>
        public ulong MaxResults { get; protected set; }

        /// <summary>
        /// <para>The search mode (filename, filename_and_content, or deleted_filename). Note
        /// that searching file content is only available for Dropbox Business accounts.</para>
        /// </summary>
        public SearchMode Mode { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SearchArg" />.</para>
        /// </summary>
        private class SearchArgEncoder : enc.StructEncoder<SearchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SearchArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("query", value.Query, writer, enc.StringEncoder.Instance);
                WriteProperty("start", value.Start, writer, enc.UInt64Encoder.Instance);
                WriteProperty("max_results", value.MaxResults, writer, enc.UInt64Encoder.Instance);
                WriteProperty("mode", value.Mode, writer, global::Dropbox.Api.Files.SearchMode.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SearchArg" />.</para>
        /// </summary>
        private class SearchArgDecoder : enc.StructDecoder<SearchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SearchArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SearchArg Create()
            {
                return new SearchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SearchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "query":
                        value.Query = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "start":
                        value.Start = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "max_results":
                        value.MaxResults = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "mode":
                        value.Mode = global::Dropbox.Api.Files.SearchMode.Decoder.Decode(reader);
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