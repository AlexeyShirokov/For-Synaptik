//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_progect
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTraking
    {
        public int Id { get; set; }
        public Nullable<int> IdSalad { get; set; }
        public Nullable<int> IdSecondCourse { get; set; }
        public Nullable<int> IdSoups { get; set; }
        public Nullable<int> IdDrink { get; set; }
        public Nullable<int> IdWorker { get; set; }
    
        public virtual DrinkSet DrinkSet { get; set; }
        public virtual SaladSet SaladSet { get; set; }
        public virtual SecondCourseSet SecondCourseSet { get; set; }
        public virtual SoupsSet SoupsSet { get; set; }
        public virtual WorkerSet WorkerSet { get; set; }
    }
}
