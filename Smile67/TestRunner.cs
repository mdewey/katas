using System;
using System.Collections.Generic;
using Xunit;
namespace Smile67
{
  public class TestRunner
  {
    [Theory]
    [InlineData("47", ";$%§fsdfsd235??df/sdfgf5gh.000kk0000")]
    [InlineData("54929268", "sdfsd23454sdf*2342")]
    [InlineData("-210908", "fsdfsd235???34.4554s4234df-sdfgf2g3h4j442")]
    [InlineData("234676", "fsdfsd234.4554s4234df+sf234442")]
    public void TestCases(string expected, string testCase)
    {
      Assert.Equal(expected, Program.CalculateString(testCase));
    }

  }
}