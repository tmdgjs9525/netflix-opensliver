﻿using CommunityToolkit.Mvvm.DependencyInjection;
using netflix_opensliver.Core.Navigate;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace netflix_opensliver.Core.Region
{
    /// <summary>
    /// ContentControl 컨트롤에 붙이는 어태치 프로퍼티
    /// 해당 클래스로 Region을 등록한다.
    /// </summary>
    public class RegionManager : ContentControl
    {
        public static readonly DependencyProperty RegionName =
        DependencyProperty.RegisterAttached(
            "RegionName",  
            typeof(string),        
            typeof(RegionManager), 
            new PropertyMetadata(default(string), OnRegionNameChanged)
        );

        // 어태치된 프로퍼티 값 설정
        public static void SetRegionName(UIElement element, string value)
        {
            element.SetValue(RegionName, value);
        }

        // 어태치된 프로퍼티 값 가져오기
        public static string GetRegionName(UIElement element)
        {
            return (string)element.GetValue(RegionName);
        }

        private static void OnRegionNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //디자인 모드
            if (DesignerProperties.GetIsInDesignMode(d))
            {
                var control = (ContentControl)d;
                control.Content = e.NewValue;
            }
            //실행 시
            else
            {
                var navigationService = Ioc.Default.GetRequiredService<IRegionRegister>();
                navigationService.RegisterRegion((string)e.NewValue, (ContentControl)d);
            }
        }
    }
}
