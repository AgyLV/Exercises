﻿using Xunit;

namespace Exercises.Level1.Tests;

public class Array1Tests
{
    private readonly Array1 _array1 = new();

    [Theory]
    [InlineData(true, new[] { 1, 2, 6 })]
    [InlineData(true, new[] { 6, 1, 2, 3 })]
    [InlineData(false, new[] { 13, 6, 1, 2, 3 })]
    [InlineData(true, new[] { 13, 6, 1, 2, 6 })]
    [InlineData(false, new[] { 3, 2, 1 })]
    [InlineData(false, new[] { 3, 6, 1 })]
    [InlineData(true, new[] { 3, 6 })]
    [InlineData(true, new[] { 6 })]
    [InlineData(false, new[] { 3 })]
    [InlineData(true, new[] { 5, 6 })]
    [InlineData(false, new[] { 5, 5 })]
    [InlineData(true, new[] { 1, 2, 3, 4, 6 })]
    [InlineData(false, new[] { 1, 2, 3, 4 })]
    public void FirstLast6(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.FirstLast6(nums));
    }

    [Theory]
    [InlineData(false, new[] { 1, 2, 3 })]
    [InlineData(true, new[] { 1, 2, 3, 1 })]
    [InlineData(true, new[] { 1, 2, 1 })]
    [InlineData(true, new[] { 7 })]
    [InlineData(false, new int[] { })]
    [InlineData(true, new[] { 1, 2, 3, 4, 5, 1 })]
    [InlineData(false, new[] { 1, 2, 3, 4, 5, 13 })]
    [InlineData(true, new[] { 13, 2, 3, 4, 5, 13 })]
    [InlineData(true, new[] { 7, 7 })]
    public void SameFirstLast(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.SameFirstLast(nums));
    }

    [Theory]
    [InlineData(new[] { 3, 1, 4 })]
    public void MakePi(int[] expected)
    {
        Assert.Equal(expected, _array1.MakePi());
    }

    [Theory]
    [InlineData(true, new[] { 1, 2, 3 }, new[] { 7, 3 })]
    [InlineData(false, new[] { 1, 2, 3 }, new[] { 7, 3, 2 })]
    [InlineData(true, new[] { 1, 2, 3 }, new[] { 1, 3 })]
    [InlineData(true, new[] { 1, 2, 3 }, new[] { 1 })]
    [InlineData(false, new[] { 1, 2, 3 }, new[] { 2 })]
    public void CommonEnd(bool expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.CommonEnd(a, b));
    }

    [Theory]
    [InlineData(6, new[] { 1, 2, 3 })]
    [InlineData(18, new[] { 5, 11, 2 })]
    [InlineData(7, new[] { 7, 0, 0 })]
    [InlineData(4, new[] { 1, 2, 1 })]
    [InlineData(3, new[] { 1, 1, 1 })]
    [InlineData(11, new[] { 2, 7, 2 })]
    public void Sum3(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Sum3(nums));
    }

    [Theory]
    [InlineData(new[] { 2, 3, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 11, 9, 5 }, new[] { 5, 11, 9 })]
    [InlineData(new[] { 0, 0, 7 }, new[] { 7, 0, 0 })]
    [InlineData(new[] { 2, 1, 1 }, new[] { 1, 2, 1 })]
    [InlineData(new[] { 0, 1, 0 }, new[] { 0, 0, 1 })]
    public void RotateLeft3(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.RotateLeft3(nums));
    }

    [Theory]
    [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 9, 11, 5 }, new[] { 5, 11, 9 })]
    [InlineData(new[] { 0, 0, 7 }, new[] { 7, 0, 0 })]
    [InlineData(new[] { 2, 1, 2 }, new[] { 2, 1, 2 })]
    [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
    [InlineData(new[] { 3, 11, 2 }, new[] { 2, 11, 3 })]
    [InlineData(new[] { 5, 6, 0 }, new[] { 0, 6, 5 })]
    [InlineData(new[] { 3, 2, 7 }, new[] { 7, 2, 3 })]
    public void Reverse3(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Reverse3(nums));
    }

    [Theory]
    [InlineData(new[] { 3, 3, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 11, 11, 11 }, new[] { 11, 5, 9 })]
    [InlineData(new[] { 3, 3, 3 }, new[] { 2, 11, 3 })]
    [InlineData(new[] { 11, 11, 11 }, new[] { 11, 3, 3 })]
    [InlineData(new[] { 11, 11, 11 }, new[] { 3, 11, 11 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 2, 2 })]
    [InlineData(new[] { 2, 2, 2 }, new[] { 2, 11, 2 })]
    [InlineData(new[] { 1, 1, 1 }, new[] { 0, 0, 1 })]
    public void MaxEnd3(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MaxEnd3(nums));
    }

    [Theory]
    [InlineData(3, new[] { 1, 2, 3 })]
    [InlineData(2, new[] { 1, 1 })]
    [InlineData(2, new[] { 1, 1, 1, 1 })]
    [InlineData(3, new[] { 1, 2 })]
    [InlineData(1, new[] { 1 })]
    [InlineData(0, new int[] { })]
    [InlineData(9, new[] { 4, 5, 6 })]
    [InlineData(4, new[] { 4 })]
    public void Sum2(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Sum2(nums));
    }

    [Theory]
    [InlineData(new[] { 2, 5 }, new[] { 1, 2, 3 }, new[] { 4, 5, 6 })]
    [InlineData(new[] { 7, 8 }, new[] { 7, 7, 7 }, new[] { 3, 8, 0 })]
    [InlineData(new[] { 2, 4 }, new[] { 5, 2, 9 }, new[] { 1, 4, 5 })]
    [InlineData(new[] { 9, 8 }, new[] { 1, 9, 7 }, new[] { 4, 8, 8 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2, 3 }, new[] { 3, 1, 4 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2, 3 }, new[] { 4, 1, 1 })]
    public void MiddleWay(int[] expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.MiddleWay(a, b));
    }

    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 7, 2 }, new[] { 7, 4, 6, 2 })]
    [InlineData(new[] { 1, 3 }, new[] { 1, 2, 2, 2, 2, 2, 2, 3 })]
    [InlineData(new[] { 7, 4 }, new[] { 7, 4 })]
    [InlineData(new[] { 7, 7 }, new[] { 7 })]
    [InlineData(new[] { 5, 9 }, new[] { 5, 2, 9 })]
    [InlineData(new[] { 2, 1 }, new[] { 2, 3, 4, 1 })]
    public void MakeEnds(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MakeEnds(nums));
    }

    [Theory]
    [InlineData(true, new[] { 2, 5 })]
    [InlineData(true, new[] { 4, 3 })]
    [InlineData(false, new[] { 4, 5 })]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(true, new[] { 3, 2 })]
    [InlineData(true, new[] { 3, 3 })]
    [InlineData(false, new[] { 7, 7 })]
    [InlineData(true, new[] { 3, 9 })]
    [InlineData(false, new[] { 9, 5 })]
    public void Has23(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Has23(nums));
    }

    [Theory]
    [InlineData(true, new[] { 4, 5 })]
    [InlineData(false, new[] { 4, 2 })]
    [InlineData(false, new[] { 3, 5 })]
    [InlineData(true, new[] { 1, 9 })]
    [InlineData(false, new[] { 2, 9 })]
    [InlineData(false, new[] { 1, 3 })]
    [InlineData(true, new[] { 1, 1 })]
    [InlineData(false, new[] { 2, 2 })]
    [InlineData(false, new[] { 3, 3 })]
    [InlineData(true, new[] { 7, 8 })]
    [InlineData(true, new[] { 8, 7 })]
    public void No23(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.No23(nums));
    }

    [Theory]
    [InlineData(new[] { 0, 0, 0, 0, 0, 6 }, new[] { 4, 5, 6 })]
    [InlineData(new[] { 0, 0, 0, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 0, 3 }, new[] { 3 })]
    [InlineData(new[] { 0, 0 }, new[] { 0 })]
    [InlineData(new[] { 0, 0, 0, 0, 0, 7 }, new[] { 7, 7, 7 })]
    [InlineData(new[] { 0, 0, 0, 0, 0, 4 }, new[] { 3, 1, 4 })]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0, 0, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 1, 2, 3, 0 })]
    [InlineData(new[] { 0, 0, 0, 4 }, new[] { 2, 4 })]
    public void MakeLast(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MakeLast(nums));
    }

    [Theory]
    [InlineData(true, new[] { 2, 2 })]
    [InlineData(true, new[] { 3, 3 })]
    [InlineData(false, new[] { 2, 3 })]
    [InlineData(false, new[] { 3, 2 })]
    [InlineData(false, new[] { 4, 5 })]
    [InlineData(false, new[] { 2 })]
    [InlineData(false, new[] { 3 })]
    [InlineData(false, new int[] { })]
    [InlineData(false, new[] { 3, 4 })]
    public void Double23(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Double23(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2, 0 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 2, 0, 5 }, new[] { 2, 3, 5 })]
    [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
    [InlineData(new[] { 3, 2, 1 }, new[] { 3, 2, 1 })]
    [InlineData(new[] { 2, 2, 0 }, new[] { 2, 2, 3 })]
    [InlineData(new[] { 2, 0, 3 }, new[] { 2, 3, 3 })]
    public void Fix23(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Fix23(nums));
    }

    [Theory]
    [InlineData(2, new[] { 1, 2, 3 }, new[] { 1, 3 })]
    [InlineData(1, new[] { 7, 2, 3 }, new[] { 1 })]
    [InlineData(1, new[] { 1, 2 }, new int[] { })]
    [InlineData(1, new int[] { }, new[] { 1, 2 })]
    [InlineData(0, new[] { 7 }, new int[] { })]
    [InlineData(1, new[] { 7 }, new[] { 1 })]
    [InlineData(2, new[] { 1 }, new[] { 1 })]
    [InlineData(0, new[] { 7 }, new[] { 8 })]
    [InlineData(0, new int[] { }, new int[] { })]
    [InlineData(2, new[] { 1, 3 }, new[] { 1 })]
    public void Start1(int expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.Start1(a, b));
    }

    [Theory]
    [InlineData(new[] { 3, 4 }, new[] { 1, 2 }, new[] { 3, 4 })]
    [InlineData(new[] { 3, 4 }, new[] { 3, 4 }, new[] { 1, 2 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 1 }, new[] { 2, 1 })]
    [InlineData(new[] { 2, 2 }, new[] { 2, 2 }, new[] { 1, 3 })]
    [InlineData(new[] { 1, 3 }, new[] { 1, 3 }, new[] { 2, 2 })]
    [InlineData(new[] { 6, 7 }, new[] { 6, 7 }, new[] { 3, 1 })]
    public void BiggerTwo(int[] expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.BiggerTwo(a, b));
    }

    [Theory]
    [InlineData(new[] { 2, 3 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 2, 3 }, new[] { 7, 1, 2, 3, 4, 9 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 2, 4 }, new[] { 5, 2, 4, 7 })]
    [InlineData(new[] { 4, 3 }, new[] { 9, 0, 4, 3, 9, 1 })]
    public void MakeMiddle(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MakeMiddle(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2 }, new[] { 3, 4 })]
    [InlineData(new[] { 4, 4, 2, 2 }, new[] { 4, 4 }, new[] { 2, 2 })]
    [InlineData(new[] { 9, 2, 3, 4 }, new[] { 9, 2 }, new[] { 3, 4 })]
    public void PlusTwo(int[] expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.PlusTwo(a, b));
    }

    [Theory]
    [InlineData(new[] { 4, 2, 3, 1 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 5, 6, 7, 9, 8 }, new[] { 8, 6, 7, 9, 5 })]
    [InlineData(new[] { 9, 1, 4, 1, 5, 3 }, new[] { 3, 1, 4, 1, 5, 9 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    public void SwapEnds(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.SwapEnds(nums));
    }

    [Theory]
    [InlineData(new[] { 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 7, 5, 3 }, new[] { 8, 6, 7, 5, 3, 0, 9 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void MidThree(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MidThree(nums));
    }

    [Theory]
    [InlineData(3, new[] { 1, 2, 3 })]
    [InlineData(5, new[] { 1, 5, 3 })]
    [InlineData(5, new[] { 5, 2, 3 })]
    [InlineData(3, new[] { 1, 2, 3, 1, 1 })]
    [InlineData(5, new[] { 1, 7, 3, 1, 5 })]
    [InlineData(5, new[] { 5, 1, 3, 7, 1 })]
    [InlineData(5, new[] { 5, 1, 7, 3, 7, 8, 1 })]
    [InlineData(9, new[] { 5, 1, 7, 9, 7, 8, 1 })]
    [InlineData(9, new[] { 5, 1, 7, 3, 7, 8, 9 })]
    [InlineData(5, new[] { 2, 2, 5, 1, 1 })]
    public void MaxTriple(int expected, int[] nums)
    {
        Assert.Equal(expected, _array1.MaxTriple(nums));
    }

    [Theory]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 6, 5 }, new[] { 6, 5, 0 })]
    [InlineData(new[] { 6, 5 }, new[] { 6, 5 })]
    [InlineData(new[] { 3, 1 }, new[] { 3, 1, 4, 1, 5 })]
    [InlineData(new[] { 6 }, new[] { 6 })]
    public void FrontPiece(int[] expected, int[] nums)
    {
        Assert.Equal(expected, _array1.FrontPiece(nums));
    }

    [Theory]
    [InlineData(true, new[] { 1, 3, 4, 5 })]
    [InlineData(true, new[] { 2, 1, 3, 4, 5 })]
    [InlineData(false, new[] { 1, 1, 1 })]
    [InlineData(true, new[] { 1, 3, 1 })]
    [InlineData(true, new[] { 1, 1, 3 })]
    [InlineData(false, new[] { 1, 2, 3 })]
    [InlineData(false, new[] { 3, 3, 3 })]
    [InlineData(true, new[] { 1, 3 })]
    [InlineData(false, new[] { 1, 4 })]
    [InlineData(false, new[] { 1 })]
    [InlineData(false, new int[] { })]
    [InlineData(false, new[] { 1, 1, 1, 3, 1, 1 })]
    [InlineData(true, new[] { 1, 1, 1, 1, 3, 1 })]
    [InlineData(true, new[] { 1, 1, 3, 1, 1 })]
    [InlineData(true, new[] { 1, 1, 1, 1, 3 })]
    [InlineData(false, new[] { 1, 4, 1, 5 })]
    [InlineData(false, new[] { 1, 1, 2, 3 })]
    [InlineData(false, new[] { 2, 3, 2, 1 })]
    [InlineData(true, new[] { 2, 3, 1, 3 })]
    [InlineData(true, new[] { 1, 2, 3, 4, 1, 3 })]
    public void Unlucky1(bool expected, int[] nums)
    {
        Assert.Equal(expected, _array1.Unlucky1(nums));
    }

    [Theory]
    [InlineData(new[] { 4, 5 }, new[] { 4, 5 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 4, 1 }, new[] { 4 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2 }, new int[] { }, new[] { 1, 2 })]
    [InlineData(new[] { 3, 1 }, new[] { 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 3, 1 }, new[] { 3 }, new[] { 1 })]
    [InlineData(new[] { 3, 1 }, new[] { 3, 1, 4 }, new int[] { })]
    [InlineData(new[] { 1, 1 }, new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2, 3 }, new[] { 7, 8 })]
    [InlineData(new[] { 7, 8 }, new[] { 7, 8 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 7, 1 }, new[] { 7 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 5, 4 }, new[] { 5, 4 }, new[] { 2, 3, 7 })]
    public void Make2(int[] expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.Make2(a, b));
    }

    [Theory]
    [InlineData(new[] { 1, 7 }, new[] { 1, 2, 3 }, new[] { 7, 9, 8 })]
    [InlineData(new[] { 1, 2 }, new[] { 1 }, new[] { 2 })]
    [InlineData(new[] { 2 }, new int[] { }, new[] { 2, 8 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new[] { 3, 1 }, new[] { 3 }, new[] { 1, 4, 1, 9 })]
    [InlineData(new[] { 1 }, new[] { 1, 4, 1, 9 }, new int[] { })]
    public void Front11(int[] expected, int[] a, int[] b)
    {
        Assert.Equal(expected, _array1.Front11(a, b));
    }
}
