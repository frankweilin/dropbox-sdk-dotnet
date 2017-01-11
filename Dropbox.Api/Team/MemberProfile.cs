// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Basic member profile.</para>
    /// </summary>
    /// <seealso cref="GroupMemberInfo" />
    /// <seealso cref="TeamMemberProfile" />
    public class MemberProfile
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberProfile> Encoder = new MemberProfileEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberProfile> Decoder = new MemberProfileDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberProfile" /> class.</para>
        /// </summary>
        /// <param name="teamMemberId">ID of user as a member of a team.</param>
        /// <param name="email">Email address of user.</param>
        /// <param name="emailVerified">Is true if the user's email is verified to be owned by
        /// the user.</param>
        /// <param name="status">The user's status as a member of a specific team.</param>
        /// <param name="name">Representations for a person's name.</param>
        /// <param name="membershipType">The user's membership type: full (normal team member)
        /// vs limited (does not use a license; no access to the team's shared quota).</param>
        /// <param name="externalId">External ID that a team can attach to the user. An
        /// application using the API may find it easier to use their own IDs instead of
        /// Dropbox IDs like account_id or team_member_id.</param>
        /// <param name="accountId">A user's account identifier.</param>
        public MemberProfile(string teamMemberId,
                             string email,
                             bool emailVerified,
                             TeamMemberStatus status,
                             Dropbox.Api.Users.Name name,
                             TeamMembershipType membershipType,
                             string externalId = null,
                             string accountId = null)
        {
            if (teamMemberId == null)
            {
                throw new sys.ArgumentNullException("teamMemberId");
            }

            if (email == null)
            {
                throw new sys.ArgumentNullException("email");
            }

            if (status == null)
            {
                throw new sys.ArgumentNullException("status");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (membershipType == null)
            {
                throw new sys.ArgumentNullException("membershipType");
            }

            if (accountId != null)
            {
                if (accountId.Length < 40)
                {
                    throw new sys.ArgumentOutOfRangeException("accountId", "Length should be at least 40");
                }
                if (accountId.Length > 40)
                {
                    throw new sys.ArgumentOutOfRangeException("accountId", "Length should be at most 40");
                }
            }

            this.TeamMemberId = teamMemberId;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.Status = status;
            this.Name = name;
            this.MembershipType = membershipType;
            this.ExternalId = externalId;
            this.AccountId = accountId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberProfile" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberProfile()
        {
        }

        /// <summary>
        /// <para>ID of user as a member of a team.</para>
        /// </summary>
        public string TeamMemberId { get; protected set; }

        /// <summary>
        /// <para>Email address of user.</para>
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// <para>Is true if the user's email is verified to be owned by the user.</para>
        /// </summary>
        public bool EmailVerified { get; protected set; }

        /// <summary>
        /// <para>The user's status as a member of a specific team.</para>
        /// </summary>
        public TeamMemberStatus Status { get; protected set; }

        /// <summary>
        /// <para>Representations for a person's name.</para>
        /// </summary>
        public Dropbox.Api.Users.Name Name { get; protected set; }

        /// <summary>
        /// <para>The user's membership type: full (normal team member) vs limited (does not
        /// use a license; no access to the team's shared quota).</para>
        /// </summary>
        public TeamMembershipType MembershipType { get; protected set; }

        /// <summary>
        /// <para>External ID that a team can attach to the user. An application using the API
        /// may find it easier to use their own IDs instead of Dropbox IDs like account_id or
        /// team_member_id.</para>
        /// </summary>
        public string ExternalId { get; protected set; }

        /// <summary>
        /// <para>A user's account identifier.</para>
        /// </summary>
        public string AccountId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberProfile" />.</para>
        /// </summary>
        private class MemberProfileEncoder : enc.StructEncoder<MemberProfile>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberProfile value, enc.IJsonWriter writer)
            {
                WriteProperty("team_member_id", value.TeamMemberId, writer, enc.StringEncoder.Instance);
                WriteProperty("email", value.Email, writer, enc.StringEncoder.Instance);
                WriteProperty("email_verified", value.EmailVerified, writer, enc.BooleanEncoder.Instance);
                WriteProperty("status", value.Status, writer, Dropbox.Api.Team.TeamMemberStatus.Encoder);
                WriteProperty("name", value.Name, writer, Dropbox.Api.Users.Name.Encoder);
                WriteProperty("membership_type", value.MembershipType, writer, Dropbox.Api.Team.TeamMembershipType.Encoder);
                if (value.ExternalId != null)
                {
                    WriteProperty("external_id", value.ExternalId, writer, enc.StringEncoder.Instance);
                }
                if (value.AccountId != null)
                {
                    WriteProperty("account_id", value.AccountId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberProfile" />.</para>
        /// </summary>
        private class MemberProfileDecoder : enc.StructDecoder<MemberProfile>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberProfile" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberProfile Create()
            {
                return new MemberProfile();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberProfile value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_member_id":
                        value.TeamMemberId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "email":
                        value.Email = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "email_verified":
                        value.EmailVerified = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "status":
                        value.Status = Dropbox.Api.Team.TeamMemberStatus.Decoder.Decode(reader);
                        break;
                    case "name":
                        value.Name = Dropbox.Api.Users.Name.Decoder.Decode(reader);
                        break;
                    case "membership_type":
                        value.MembershipType = Dropbox.Api.Team.TeamMembershipType.Decoder.Decode(reader);
                        break;
                    case "external_id":
                        value.ExternalId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "account_id":
                        value.AccountId = enc.StringDecoder.Instance.Decode(reader);
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