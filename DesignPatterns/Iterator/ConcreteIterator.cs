using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{

    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;


        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }
            return ret;
        }

        
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }



    }


}
