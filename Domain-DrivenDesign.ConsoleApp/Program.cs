using BenchmarkDotNet.Running;
using Domain_DrivenDesign.ConsoleApp.BenchMark;
using System;
using System.Linq;

namespace Domain_DrivenDesign.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guid guid = Guid.NewGuid();
            //A a1 = new(guid);
            //A a2 = new(guid);

            //Console.WriteLine(a1.Equals(a2));
            BenchmarkRunner.Run<BenchMarkService>();
            Console.ReadLine();
        }
    }
}

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; set; }

    public Entity(Guid id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        if (obj is not Entity entity)
            return false;

        if (obj.GetType() != GetType())
            return false;

        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public bool Equals(Entity? other)
    {
        if (other is null)
            return false;

        if (other is not Entity entity)
            return false;

        if (other.GetType() != GetType())
            return false;

        return entity.Id == Id;
    }
}

public class A : Entity
{
    public A(Guid id) : base(id){}
}