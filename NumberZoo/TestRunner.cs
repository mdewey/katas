using System;
using System.Collections.Generic;
using Xunit;
namespace NumberZoo
{
  public class TestRunner
  {
    [Theory]
    [InlineData(2, new int[] { 1, 3, 4, 5, 6, 7, 8 })]
    [InlineData(3, new int[] { 7, 8, 1, 2, 4, 5, 6 })]
    [InlineData(4, new int[] { 1, 2, 3, 5 })]
    [InlineData(3, new int[] { 1, 2 })]
    [InlineData(1, new int[] { 2, 3, 4 })]
    [InlineData(12, new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 })]
    public void TestCases(int expected, int[] data)
    {
      Assert.Equal(expected, Program.FindNumber(data));
    }

  }
}