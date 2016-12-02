﻿using System;
using System.Collections.Generic;
using vfs2poc.Configuration.Interfaces;

namespace vfs2poc.Configuration.Model
{
    [Serializable]
    public class EntityType : ModelObject, IEntityType
    {
        public EntityType()
        {
            Fields = new List<IField>();
        }

        public IApplication Application { get; set; }

        public IList<IField> Fields { get; set; }
    }
}
