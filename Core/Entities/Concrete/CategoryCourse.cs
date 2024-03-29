﻿using System;
using System.Collections.Generic;

namespace Core.Entities.Concrete
{
    public class CategoryCourse : IEntity
    {
        public Guid CategoryCourseId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid CourseId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Course Course { get; set; }
    }
}
