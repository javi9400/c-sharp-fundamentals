using System;

namespace armena.BL.Model
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }

        public bool IsValid
        { 
            get
        {
            return Validate();
        }
        }

        public abstract bool Validate();
        public EntityStateOption EntityState {get;set;}
    }
}