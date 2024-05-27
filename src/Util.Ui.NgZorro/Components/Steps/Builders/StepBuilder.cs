﻿using Util.Ui.Angular.Builders;
using Util.Ui.Angular.Configs;
using Util.Ui.NgZorro.Configs;
using Util.Ui.NgZorro.Enums;
using Util.Ui.NgZorro.Extensions;

namespace Util.Ui.NgZorro.Components.Steps.Builders; 

/// <summary>
/// 步骤标签生成器
/// </summary>
public class StepBuilder : AngularTagBuilder {
    /// <summary>
    /// 配置
    /// </summary>
    private readonly Config _config;

    /// <summary>
    /// 初始化步骤标签生成器
    /// </summary>
    /// <param name="config">配置</param>
    public StepBuilder( Config config ) : base( config,"nz-step" ) {
        _config = config;
    }

    /// <summary>
    /// 配置标题
    /// </summary>
    public StepBuilder Title() {
        SetTitle( _config.GetValue( UiConst.Title ) );
        AttributeIfNotEmpty( "[nzTitle]", _config.GetValue( AngularConst.BindTitle ) );
        return this;
    }

    /// <summary>
    /// 设置标题
    /// </summary>
    private void SetTitle( string value ) {
        var options = NgZorroOptionsService.GetOptions();
        if ( options.EnableI18n ) {
            this.AttributeByI18n( "[nzTitle]", value );
            return;
        }
        AttributeIfNotEmpty( "nzTitle", value );
    }

    /// <summary>
    /// 配置子标题
    /// </summary>
    public StepBuilder Subtitle() {
        SetSubtitle( _config.GetValue( UiConst.Subtitle ) );
        AttributeIfNotEmpty( "[nzSubtitle]", _config.GetValue( AngularConst.BindSubtitle ) );
        return this;
    }

    /// <summary>
    /// 设置子标题
    /// </summary>
    private void SetSubtitle( string value ) {
        var options = NgZorroOptionsService.GetOptions();
        if ( options.EnableI18n ) {
            this.AttributeByI18n( "[nzSubtitle]", value );
            return;
        }
        AttributeIfNotEmpty( "nzSubtitle", value );
    }

    /// <summary>
    /// 配置描述
    /// </summary>
    public StepBuilder Description() {
        AttributeIfNotEmpty( "nzDescription", _config.GetValue( UiConst.Description ) );
        AttributeIfNotEmpty( "[nzDescription]", _config.GetValue( AngularConst.BindDescription ) );
        return this;
    }

    /// <summary>
    /// 配置图标
    /// </summary>
    public StepBuilder Icon() {
        AttributeIfNotEmpty( "nzIcon", _config.GetValue<AntDesignIcon?>( UiConst.Icon )?.Description() );
        AttributeIfNotEmpty( "[nzIcon]", _config.GetValue( AngularConst.BindIcon ) );
        return this;
    }

    /// <summary>
    /// 配置状态
    /// </summary>
    public StepBuilder Status() {
        AttributeIfNotEmpty( "nzStatus", _config.GetValue<StepStatus?>( UiConst.Status )?.Description() );
        AttributeIfNotEmpty( "[nzStatus]", _config.GetValue( AngularConst.BindStatus ) );
        return this;
    }

    /// <summary>
    /// 配置禁用
    /// </summary>
    public StepBuilder Disabled() {
        AttributeIfNotEmpty( "[nzDisabled]", _config.GetValue( UiConst.Disabled ) );
        return this;
    }

    /// <summary>
    /// 配置进度百分比
    /// </summary>
    public StepBuilder Percentage() {
        AttributeIfNotEmpty( "[nzPercentage]", _config.GetValue( UiConst.Percentage ) );
        return this;
    }

    /// <summary>
    /// 配置
    /// </summary>
    public override void Config() {
        base.Config();
        Title().Subtitle().Description().Icon().Status().Disabled().Percentage();
    }
}