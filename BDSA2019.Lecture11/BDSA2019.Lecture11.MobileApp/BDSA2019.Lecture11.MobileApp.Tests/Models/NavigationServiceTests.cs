﻿using BDSA2019.Lecture11.MobileApp.Models;
using BDSA2019.Lecture11.MobileApp.Views;
using Moq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xunit;

namespace BDSA2019.Lecture11.MobileApp.Tests.Models
{
    public class NavigationServiceTests
    {
        [Fact]
        public async Task BackAsync_Pop()
        {
            var navigation = new Mock<INavigation>();

            var service = new NavigationService(navigation.Object);

            await service.BackAsync();

            navigation.Verify(s => s.PopAsync());
        }

        [Fact]
        public async Task CancelAsync_PopModal()
        {
            var navigation = new Mock<INavigation>();

            var service = new NavigationService(navigation.Object);

            await service.CancelAsync();

            navigation.Verify(s => s.PopModalAsync());
        }
    }
}
