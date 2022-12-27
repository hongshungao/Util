﻿using Microsoft.Extensions.Logging;
using Util.Scheduling.Quartz.Sample.Services;

namespace Util.Scheduling.Quartz.Sample.Jobs {
    /// <summary>
    /// 测试任务1
    /// </summary>
    public class TestJob1 : JobBase {
        /// <inheritdoc />
        protected override void ConfigDetail( IJobInfo job ) {
            job.Name( "test" );
        }

        /// <inheritdoc />
        protected override void ConfigTrigger( IJobTrigger trigger ) {
            trigger.Name( "test_trigger" ).RepeatCount(0).IntervalInSeconds(1 );
        }

        /// <inheritdoc />
        protected override Task Execute( QuartzExecutionContext context ) {
            var log = context.GetService<ILogger<TestJob1>>();
            var customer = context.GetData<Customer>();
            log?.LogDebug( $"time:{DateTime.Now},name:{customer.Name}" );
            return Task.CompletedTask;
        }
    }
}