using Main.MemoryManagement;
using System;

namespace Main
{
    public static class ApiFactory
    {
        public static Api Create(AbstractGameProcess gameProcess)
        {
            return new Api(new ProcessMethods(), gameProcess);
        }
    }
}