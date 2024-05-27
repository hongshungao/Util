﻿using System.Text;
using Util.Helpers;
using Util.Ui.Angular.Configs;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.DatePickers;
using Util.Ui.NgZorro.Enums;
using Util.Ui.NgZorro.Tests.Samples;
using Util.Ui.TagHelpers;
using Xunit;
using Xunit.Abstractions;

namespace Util.Ui.NgZorro.Tests.DatePickers {
    /// <summary>
    /// 日期选择测试
    /// </summary>
    public partial class DatePickerTagHelperTest {
        /// <summary>
        /// 输出工具
        /// </summary>
        private readonly ITestOutputHelper _output;
        /// <summary>
        /// TagHelper包装器
        /// </summary>
        private readonly TagHelperWrapper<Customer> _wrapper;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public DatePickerTagHelperTest( ITestOutputHelper output ) {
            _output = output;
            _wrapper = new DatePickerTagHelper().ToWrapper<Customer>();
            Id.SetId( "id" );
        }

        /// <summary>
        /// 获取结果
        /// </summary>
        private string GetResult() {
            var result = _wrapper.GetResult();
            _output.WriteLine( result );
            return result;
        }

        /// <summary>
        /// 测试默认输出
        /// </summary>
        [Fact]
        public void TestDefault() {
            var result = new StringBuilder();
            result.Append( "<nz-date-picker></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试输入框标识
        /// </summary>
        [Fact]
        public void TestNzId() {
            _wrapper.SetContextAttribute( UiConst.NzId, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzId=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试输入框标识
        /// </summary>
        [Fact]
        public void TestBindNzId() {
            _wrapper.SetContextAttribute( AngularConst.BindNzId, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzId]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试允许清除
        /// </summary>
        [Fact]
        public void TestAllowClear() {
            _wrapper.SetContextAttribute( UiConst.AllowClear, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzAllowClear]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试自动聚焦
        /// </summary>
        [Fact]
        public void TestAutoFocus() {
            _wrapper.SetContextAttribute( UiConst.AutoFocus, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzAutoFocus]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试浮层是否应带有背景板
        /// </summary>
        [Fact]
        public void TestBackdrop() {
            _wrapper.SetContextAttribute( UiConst.Backdrop, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzBackdrop]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试默认面板日期
        /// </summary>
        [Fact]
        public void TestDefaultPickerValue() {
            _wrapper.SetContextAttribute( UiConst.DefaultPickerValue, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzDefaultPickerValue=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试默认面板日期
        /// </summary>
        [Fact]
        public void TestBindDefaultPickerValue() {
            _wrapper.SetContextAttribute( AngularConst.BindDefaultPickerValue, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDefaultPickerValue]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试禁用
        /// </summary>
        [Fact]
        public void TestDisabled() {
            _wrapper.SetContextAttribute( UiConst.Disabled, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDisabled]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试不可选择日期函数
        /// </summary>
        [Fact]
        public void TestDisabledDate() {
            _wrapper.SetContextAttribute( UiConst.DisabledDate, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDisabledDate]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试不可选择时间函数
        /// </summary>
        [Fact]
        public void TestDisabledTime() {
            _wrapper.SetContextAttribute( UiConst.DisabledTime, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDisabledTime]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试弹出日历样式类名
        /// </summary>
        [Fact]
        public void TestDropdownClassName() {
            _wrapper.SetContextAttribute( UiConst.DropdownClassName, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzDropdownClassName=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试弹出日历样式类名
        /// </summary>
        [Fact]
        public void TestBindDropdownClassName() {
            _wrapper.SetContextAttribute( AngularConst.BindDropdownClassName, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDropdownClassName]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试弹出日历样式
        /// </summary>
        [Fact]
        public void TestPopupStyle() {
            _wrapper.SetContextAttribute( UiConst.PopupStyle, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzPopupStyle]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试日期格式
        /// </summary>
        [Fact]
        public void TestFormat() {
            _wrapper.SetContextAttribute( UiConst.Format, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzFormat=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试日期格式
        /// </summary>
        [Fact]
        public void TestBindFormat() {
            _wrapper.SetContextAttribute( AngularConst.BindFormat, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzFormat]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试只读
        /// </summary>
        [Fact]
        public void TestInputReadOnly() {
            _wrapper.SetContextAttribute( UiConst.InputReadonly, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzInputReadOnly]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试国际化
        /// </summary>
        [Fact]
        public void TestLocale() {
            _wrapper.SetContextAttribute( UiConst.Locale, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzLocale]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试模式
        /// </summary>
        [Fact]
        public void TestMode() {
            _wrapper.SetContextAttribute( UiConst.Mode, DatePickerMode.Month );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzMode=\"month\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试模式 - 周,修复格式字符串
        /// </summary>
        [Fact]
        public void TestMode_Week() {
            _wrapper.SetContextAttribute( UiConst.Mode, DatePickerMode.Week );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzFormat=\"yyyy-ww\" nzMode=\"week\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试模式
        /// </summary>
        [Fact]
        public void TestBindMode() {
            _wrapper.SetContextAttribute( AngularConst.BindMode, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzMode]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试占位提示
        /// </summary>
        [Fact]
        public void TestPlaceholder() {
            _wrapper.SetContextAttribute( UiConst.Placeholder, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzPlaceHolder=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试占位提示
        /// </summary>
        [Fact]
        public void TestBindPlaceholder() {
            _wrapper.SetContextAttribute( AngularConst.BindPlaceholder, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzPlaceHolder]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试额外页脚
        /// </summary>
        [Fact]
        public void TestRenderExtraFooter() {
            _wrapper.SetContextAttribute( UiConst.RenderExtraFooter, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzRenderExtraFooter=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试额外页脚
        /// </summary>
        [Fact]
        public void TestBindRenderExtraFooter() {
            _wrapper.SetContextAttribute( AngularConst.BindRenderExtraFooter, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzRenderExtraFooter]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试输入框大小
        /// </summary>
        [Fact]
        public void TestSize() {
            _wrapper.SetContextAttribute( UiConst.Size, InputSize.Large );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzSize=\"large\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试输入框大小
        /// </summary>
        [Fact]
        public void TestBindSize() {
            _wrapper.SetContextAttribute( AngularConst.BindSize, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzSize]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试后缀图标
        /// </summary>
        [Fact]
        public void TestSuffixIcon() {
            _wrapper.SetContextAttribute( UiConst.SuffixIcon, AntDesignIcon.AccountBook );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzSuffixIcon=\"account-book\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试后缀图标
        /// </summary>
        [Fact]
        public void TestBindSuffixIcon() {
            _wrapper.SetContextAttribute( AngularConst.BindSuffixIcon, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzSuffixIcon]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试移除边框
        /// </summary>
        [Fact]
        public void TestBorderless() {
            _wrapper.SetContextAttribute( UiConst.Borderless, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzBorderless]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试内联模式
        /// </summary>
        [Fact]
        public void TestInline() {
            _wrapper.SetContextAttribute( UiConst.Inline, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzInline]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试显示周数
        /// </summary>
        [Fact]
        public void TestShowWeekNumber() {
            _wrapper.SetContextAttribute( UiConst.ShowWeekNumber, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzShowWeekNumber]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试自定义日期单元格内容
        /// </summary>
        [Fact]
        public void TestDateRender() {
            _wrapper.SetContextAttribute( UiConst.DateRender, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzDateRender]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试显示时间选择
        /// </summary>
        [Fact]
        public void TestShowTime() {
            _wrapper.SetContextAttribute( UiConst.ShowTime, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzShowTime]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试显示“今天”按钮
        /// </summary>
        [Fact]
        public void TestShowToday() {
            _wrapper.SetContextAttribute( UiConst.ShowToday, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzShowToday]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试显示“此刻”按钮
        /// </summary>
        [Fact]
        public void TestShowNow() {
            _wrapper.SetContextAttribute( UiConst.ShowNow, "true" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzShowNow]=\"true\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试状态
        /// </summary>
        [Fact]
        public void TestStatus() {
            _wrapper.SetContextAttribute( UiConst.Status, FormControlStatus.Error );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzStatus=\"error\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试状态
        /// </summary>
        [Fact]
        public void TestBindStatus() {
            _wrapper.SetContextAttribute( AngularConst.BindStatus, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzStatus]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试日期选择框弹出位置
        /// </summary>
        [Fact]
        public void TestPlacement() {
            _wrapper.SetContextAttribute( UiConst.Placement, DatePickerPlacement.TopLeft );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker nzPlacement=\"topLeft\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试日期选择框弹出位置
        /// </summary>
        [Fact]
        public void TestBindPlacement() {
            _wrapper.SetContextAttribute( AngularConst.BindPlacement, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker [nzPlacement]=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试必填项验证
        /// </summary>
        [Fact]
        public void TestRequired() {
            _wrapper.SetContextAttribute( UiConst.Required, "true" );
            _wrapper.SetContextAttribute( AngularConst.NgModel, "model" );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-control [nzErrorTip]=\"vt_id\">" );
            result.Append( "<nz-date-picker #v_id=\"xValidationExtend\" x-validation-extend=\"\" [(ngModel)]=\"model\" [required]=\"true\"></nz-date-picker>" );
            result.Append( "<ng-template #vt_id=\"\">" );
            result.Append( "{{v_id.getErrorMessage()}}" );
            result.Append( "</ng-template>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试必填项消息
        /// </summary>
        [Fact]
        public void TestRequiredMessage() {
            _wrapper.SetContextAttribute( UiConst.Required, "true" );
            _wrapper.SetContextAttribute( UiConst.RequiredMessage, "a" );
            _wrapper.SetContextAttribute( AngularConst.NgModel, "model" );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-control [nzErrorTip]=\"vt_id\">" );
            result.Append( "<nz-date-picker #v_id=\"xValidationExtend\" requiredMessage=\"a\" x-validation-extend=\"\" [(ngModel)]=\"model\" [required]=\"true\"></nz-date-picker>" );
            result.Append( "<ng-template #vt_id=\"\">" );
            result.Append( "{{v_id.getErrorMessage()}}" );
            result.Append( "</ng-template>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试内容
        /// </summary>
        [Fact]
        public void TestContent() {
            _wrapper.AppendContent( "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker>a</nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试弹出关闭日历事件
        /// </summary>
        [Fact]
        public void TestOnOpenChange() {
            _wrapper.SetContextAttribute( UiConst.OnOpenChange, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker (nzOnOpenChange)=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试确定事件
        /// </summary>
        [Fact]
        public void TestOnOk() {
            _wrapper.SetContextAttribute( UiConst.OnOk, "a" );
            var result = new StringBuilder();
            result.Append( "<nz-date-picker (nzOnOk)=\"a\"></nz-date-picker>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试间距项
        /// </summary>
        [Fact]
        public void TestSpaceItem() {
            _wrapper.SetContextAttribute( UiConst.LabelText, "a" );
            _wrapper.SetContextAttribute( UiConst.SpaceItem, true );

            var result = new StringBuilder();
            result.Append( "<nz-form-item *nzSpaceItem=\"\">" );
            result.Append( "<nz-form-label>a</nz-form-label>" );
            result.Append( "<nz-form-control>" );
            result.Append( "<nz-date-picker></nz-date-picker>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }
    }
}