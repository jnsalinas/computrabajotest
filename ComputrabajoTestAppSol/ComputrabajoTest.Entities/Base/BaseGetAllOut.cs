using System;
using System.Collections.ObjectModel;

namespace ComputrabajoTest.Entities.Base
{
	public class BaseGetAllOut<T> : BaseOut
	{
        public ObservableCollection<T> listResult { get; set; }
        public int? totalRows { get; set; }
    }
}

