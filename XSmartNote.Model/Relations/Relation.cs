﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSmartNote.Model.Relations
{
    public class Relation
    {
        /// <summary>
        /// RelationId
        /// </summary>
        public virtual Guid RelationId{ get; set; }
        /// <summary>
        /// Note ID
        /// </summary>
        public virtual Guid PostId { get; set; }
        /// <summary>
        /// Tag ID
        /// </summary>
        public virtual Guid TagId { get; set; }

        public virtual PostContents.PostContent Post { get; set; }


    }
}
