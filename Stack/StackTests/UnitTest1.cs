using System;
using System.Collections;
using NUnit.Framework;

namespace StackTests;

public class Tests
{
    
    [Test]
    public void TestStackCreation()
    {
        Assert.DoesNotThrow(()=>new StackImplementation.Stack<int>());
    }

    [Test]
    [TestCase(18)]
    public void TestPushMethod(int data)
    {
        var i = data;
        var stack = new StackImplementation.Stack<int>();
        stack.Push(data);
        Assert.That(stack.Peek(),Is.EqualTo(data));
    }
    [Test]
    [TestCase(123,56,7,2,3,6,7,10,20)]
    [TestCase(10,23,6,8,8,2,3142,3923,7,-2939,39,2)]
    public void TestPopMethod( params int [] list)
    {
        var stack = new StackImplementation.Stack<int>();
        foreach (var i in list)
        {
            stack.Push(i);
        }
        Assert.That(stack.Pop(),Is.EqualTo(list[list.Length-1]));
        Assert.That(stack.Pop(),Is.EqualTo(list[list.Length-2]));
        Assert.That(stack.Pop(),Is.EqualTo(list[list.Length-3]));
        Assert.That(stack.Pop(),Is.EqualTo(list[list.Length-4]));
    }

    [Test]
    public void TestEmptyMethod()
    {
        Assert.Throws<InvalidOperationException>(() => new StackImplementation.Stack<int>().Pop());
    }
}

