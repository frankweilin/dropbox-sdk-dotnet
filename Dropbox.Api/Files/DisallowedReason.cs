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
    /// <para>Errors for <see cref="Dropbox.Api.Files.Routes.FilesRoutes.DownloadAsync" /> when
    /// download is disallowed or forbidden.</para>
    /// </summary>
    public class DisallowedReason : enc.IEncodable<DisallowedReason>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DisallowedReason" />
        /// class.</para>
        /// </summary>
        public DisallowedReason()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Permission</para>
        /// </summary>
        public bool IsPermission
        {
            get
            {
                return this is Permission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Permission, or <c>null</c>.</para>
        /// </summary>
        public Permission AsPermission
        {
            get
            {
                return this as Permission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Restricted</para>
        /// </summary>
        public bool IsRestricted
        {
            get
            {
                return this is Restricted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Restricted, or <c>null</c>.</para>
        /// </summary>
        public Restricted AsRestricted
        {
            get
            {
                return this as Restricted;
            }
        }

        #region IEncodable<DisallowedReason> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<DisallowedReason>.Encode(enc.IEncoder encoder)
        {
            if (this.IsPermission)
            {
                ((enc.IEncodable<Permission>)this).Encode(encoder);
            }
            else if (this.IsRestricted)
            {
                ((enc.IEncodable<Restricted>)this).Encode(encoder);
            }
            else
            {
                throw new sys.InvalidOperationException();
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        DisallowedReason enc.IEncodable<DisallowedReason>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "permission":
                return Permission.Instance;
            case "restricted":
                using (var obj = decoder.GetObject())
                {
                    return new Restricted(obj.GetFieldObject<Dropbox.Api.Files.Restricted>("restricted"));
                }
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>The requesting user has no permission to access the file.</para>
        /// </summary>
        public sealed class Permission : DisallowedReason, enc.IEncodable<Permission>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Permission" /> class.</para>
            /// </summary>
            private Permission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Permission</para>
            /// </summary>
            public static readonly Permission Instance = new Permission();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Permission>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("permission");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Permission enc.IEncodable<Permission>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The download is forbidden; see the value for the reason.</para>
        /// </summary>
        public sealed class Restricted : DisallowedReason, enc.IEncodable<Restricted>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Restricted" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Restricted(Dropbox.Api.Files.Restricted value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public Dropbox.Api.Files.Restricted Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Restricted>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("restricted", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Restricted enc.IEncodable<Restricted>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}