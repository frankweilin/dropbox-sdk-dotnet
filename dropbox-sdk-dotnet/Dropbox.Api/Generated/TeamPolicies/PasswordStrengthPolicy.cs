// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamPolicies
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The password strength policy object</para>
    /// </summary>
    public class PasswordStrengthPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PasswordStrengthPolicy> Encoder = new PasswordStrengthPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PasswordStrengthPolicy> Decoder = new PasswordStrengthPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PasswordStrengthPolicy" />
        /// class.</para>
        /// </summary>
        public PasswordStrengthPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MinimalRequirements</para>
        /// </summary>
        public bool IsMinimalRequirements
        {
            get
            {
                return this is MinimalRequirements;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MinimalRequirements, or <c>null</c>.</para>
        /// </summary>
        public MinimalRequirements AsMinimalRequirements
        {
            get
            {
                return this as MinimalRequirements;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ModeratePassword</para>
        /// </summary>
        public bool IsModeratePassword
        {
            get
            {
                return this is ModeratePassword;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ModeratePassword, or <c>null</c>.</para>
        /// </summary>
        public ModeratePassword AsModeratePassword
        {
            get
            {
                return this as ModeratePassword;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is StrongPassword</para>
        /// </summary>
        public bool IsStrongPassword
        {
            get
            {
                return this is StrongPassword;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a StrongPassword, or <c>null</c>.</para>
        /// </summary>
        public StrongPassword AsStrongPassword
        {
            get
            {
                return this as StrongPassword;
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
        /// <para>Encoder for  <see cref="PasswordStrengthPolicy" />.</para>
        /// </summary>
        private class PasswordStrengthPolicyEncoder : enc.StructEncoder<PasswordStrengthPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PasswordStrengthPolicy value, enc.IJsonWriter writer)
            {
                if (value is MinimalRequirements)
                {
                    WriteProperty(".tag", "minimal_requirements", writer, enc.StringEncoder.Instance);
                    MinimalRequirements.Encoder.EncodeFields((MinimalRequirements)value, writer);
                    return;
                }
                if (value is ModeratePassword)
                {
                    WriteProperty(".tag", "moderate_password", writer, enc.StringEncoder.Instance);
                    ModeratePassword.Encoder.EncodeFields((ModeratePassword)value, writer);
                    return;
                }
                if (value is StrongPassword)
                {
                    WriteProperty(".tag", "strong_password", writer, enc.StringEncoder.Instance);
                    StrongPassword.Encoder.EncodeFields((StrongPassword)value, writer);
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
        /// <para>Decoder for  <see cref="PasswordStrengthPolicy" />.</para>
        /// </summary>
        private class PasswordStrengthPolicyDecoder : enc.UnionDecoder<PasswordStrengthPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PasswordStrengthPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PasswordStrengthPolicy Create()
            {
                return new PasswordStrengthPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PasswordStrengthPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "minimal_requirements":
                        return MinimalRequirements.Decoder.DecodeFields(reader);
                    case "moderate_password":
                        return ModeratePassword.Decoder.DecodeFields(reader);
                    case "strong_password":
                        return StrongPassword.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>User passwords will adhere to the minimal password strength policy.</para>
        /// </summary>
        public sealed class MinimalRequirements : PasswordStrengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MinimalRequirements> Encoder = new MinimalRequirementsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MinimalRequirements> Decoder = new MinimalRequirementsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MinimalRequirements" />
            /// class.</para>
            /// </summary>
            private MinimalRequirements()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MinimalRequirements</para>
            /// </summary>
            public static readonly MinimalRequirements Instance = new MinimalRequirements();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MinimalRequirements" />.</para>
            /// </summary>
            private class MinimalRequirementsEncoder : enc.StructEncoder<MinimalRequirements>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MinimalRequirements value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MinimalRequirements" />.</para>
            /// </summary>
            private class MinimalRequirementsDecoder : enc.StructDecoder<MinimalRequirements>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MinimalRequirements"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MinimalRequirements Create()
                {
                    return MinimalRequirements.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>User passwords will adhere to the moderate password strength policy.</para>
        /// </summary>
        public sealed class ModeratePassword : PasswordStrengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ModeratePassword> Encoder = new ModeratePasswordEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ModeratePassword> Decoder = new ModeratePasswordDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ModeratePassword" />
            /// class.</para>
            /// </summary>
            private ModeratePassword()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ModeratePassword</para>
            /// </summary>
            public static readonly ModeratePassword Instance = new ModeratePassword();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ModeratePassword" />.</para>
            /// </summary>
            private class ModeratePasswordEncoder : enc.StructEncoder<ModeratePassword>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ModeratePassword value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ModeratePassword" />.</para>
            /// </summary>
            private class ModeratePasswordDecoder : enc.StructDecoder<ModeratePassword>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ModeratePassword" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ModeratePassword Create()
                {
                    return ModeratePassword.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>User passwords will adhere to the very strong password strength
        /// policy.</para>
        /// </summary>
        public sealed class StrongPassword : PasswordStrengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<StrongPassword> Encoder = new StrongPasswordEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<StrongPassword> Decoder = new StrongPasswordDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="StrongPassword" />
            /// class.</para>
            /// </summary>
            private StrongPassword()
            {
            }

            /// <summary>
            /// <para>A singleton instance of StrongPassword</para>
            /// </summary>
            public static readonly StrongPassword Instance = new StrongPassword();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="StrongPassword" />.</para>
            /// </summary>
            private class StrongPasswordEncoder : enc.StructEncoder<StrongPassword>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(StrongPassword value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="StrongPassword" />.</para>
            /// </summary>
            private class StrongPasswordDecoder : enc.StructDecoder<StrongPassword>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="StrongPassword" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override StrongPassword Create()
                {
                    return StrongPassword.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PasswordStrengthPolicy
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
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}