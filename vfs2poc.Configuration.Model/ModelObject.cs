﻿using System;
using vfs2poc.Configuration.Interfaces;

namespace vfs2poc.Configuration.Model
{
    [Serializable]
    public class ModelObject : IModelObject
    {
        public Guid? Id { get; set; }

        public bool? IsFixed { get; set; }
    }
}
