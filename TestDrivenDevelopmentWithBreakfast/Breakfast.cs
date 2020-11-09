using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestDrivenDevelopmentWithBreakfast
{
    public static class Breakfast
    {

        /*
        var coffee = Breakfast.PourCoffee();
        Assert.True(typeof(Coffee) == coffee.GetType());
        */
        public static Coffee PourCoffee()
        {
            return new Coffee();
        }
        /*
        var coffee = Breakfast.PourCoffee();
        Assert.Equal("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Cold", coffee.Temperature);
        */

        public static Eggs FryEggs(int count)
        {
            Eggs eggs = new Eggs(count);
            return eggs;
        }

        /*
        var eggs = Breakfast.FryEggs(2);
        Assert.Equal(2, eggs.Length);
            Assert.Equal("2 eggs", eggs.Print());
        */

        public static Bacon FryBacon(int count)
        {
            Bacon bacon = new Bacon(count);
            return bacon;
        }

        public static void EatBacon(ref Bacon myBacons, int count)
        {
            myBacons.Length -= count;
        }
        /*
        public void TestFryingBaconLength()
        {
            var bacon = Breakfast.FryBacon(3);
            Assert.Equal(3, bacon.Length);
            Breakfast.EatBacon(ref bacon, 2);
            Assert.Equal(1, bacon.Length);
        }
        */

        public static Toast[] ToastBread (int count)
        {
            Toast[] toasts = new Toast[count];

            for (int i = 0; i < count; i++)
            {
                toasts[i] = new Toast();
            }

            return toasts;
        }

        /*
        public void TestToastingBreadLength()
        {
            var toasts = Breakfast.ToastBread(2);
            Assert.Equal(2, toasts.Length);
        }
        */
        public static void ApplyButter(Toast toast)
        {
            toast.ButterApplied = true;
        }

        public static void ApplyJam(Toast toast)
        {
            toast.JamApplied = true;
        }

        /*
        public void TestApplyingToToast()
        {
            var toasts = Breakfast.ToastBread(2);

            Breakfast.ApplyButter(toasts[0]);
            Breakfast.ApplyJam(toasts[1]);

            Assert.False(toasts[0].JamApplied);
            Assert.False(toasts[1].ButterApplied);
            Assert.True(toasts[1].JamApplied);
            Assert.True(toasts[0].ButterApplied);
        */
    }
}
