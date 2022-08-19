﻿namespace ConceptoPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id}-{FirstName}  {LastName}, " +
                $"Is acticve: {IsActive}";
        }
    }
}