﻿using System;
using Microsoft.AspNetCore.Identity;

//
// Summary:
//     Represents a user in the identity system
//
// Type parameters:
//   TKey:
//     The type used for the primary key for the user.
namespace Palamedes.API.Models
{
    public class User
    {
        //

        //
        // Summary:
        //     A random value that must change whenever a users credentials change (password
        //     changed, login removed)
        public string SecurityStamp { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their telephone address.
        [PersonalData]
        public bool PhoneNumberConfirmed { get; set; }
        //
        // Summary:
        //     Gets or sets a telephone number for the user.
        [ProtectedPersonalData]
        public string PhoneNumber { get; set; }
        //
        // Summary:
        //     Gets or sets a salted and hashed representation of the password for this user.
        public string PasswordHash { get; set; }
        //
        // Summary:
        //     Gets or sets the normalized user name for this user.
        public string NormalizedUserName { get; set; }
        //
        // Summary:
        //     Gets or sets the normalized email address for this user.
        public string NormalizedEmail { get; set; }
        //
        // Summary:
        //     Gets or sets the date and time, in UTC, when any user lockout ends.
        //
        // Remarks:
        //     A value in the past means the user is not locked out.
        public DateTimeOffset? LockoutEnd { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if the user could be locked out.
        public bool LockoutEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets the primary key for this user.
        [PersonalData]
        public string Id { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if a user has confirmed their email address.
        [PersonalData]
        public bool EmailConfirmed { get; set; }
        //
        // Summary:
        //     Gets or sets the email address for this user.
        [ProtectedPersonalData]
        public string Email { get; set; }
        //
        // Summary:
        //     A random value that must change whenever a user is persisted to the store
        public string ConcurrencyStamp { get; set; }
        //
        // Summary:
        //     Gets or sets the number of failed login attempts for the current user.
        public int AccessFailedCount { get; set; }
        //
        // Summary:
        //     Gets or sets a flag indicating if two factor authentication is enabled for this
        //     user.
        [PersonalData]
        public bool TwoFactorEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets the user name for this user.
        [ProtectedPersonalData]
        public virtual string UserName { get; set; }
    }
}
