using Decorator_Real_world;
using System;
using System.Collections.Generic;
namespace Decorator_Structural
{

    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}