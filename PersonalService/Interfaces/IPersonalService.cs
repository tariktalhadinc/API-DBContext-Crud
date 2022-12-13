<<<<<<< HEAD
﻿namespace PersonalService.Interfaces;

public interface IPersonalService
{
    public List<Personal> Get();
    public Personal Search(string nationalId);
    public void Update(string nationalId);
    public void Delete(int personalId);
    public void Add(Personal personal);
}
=======
﻿using System;
namespace PersonalService.Interfaces
{
    public interface IPersonalService
    {
        public List<Personal> Get();

        public Personal Search(string nationalId);

        public bool Add(Personal personal);

        public Personal Update(Personal request);

        public Personal Delete(Personal request);
    }
}

>>>>>>> 99ca99b0a69a88f57a1f2215384a7523e561c01f
