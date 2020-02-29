using System;
using ZodiacPerson.Models;

namespace ZodiacPerson.Tools
{
    internal static class Adapter
    {
        internal static Person CreatePerson(string firstName, string lastName, string email, DateTime birthDate)
        {
            return new Person(firstName, lastName, email, birthDate);
        }
    }
}
