using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;

namespace FashionTrend.Persistence.Repositories
{
    public class KafkaConsumer : IKafkaConsumer
    {
        private bool isConsuming = false;

        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived;

        private IConsumer<Ignore, string> consumer;

        public async Task StartConsumingAsync(CancellationToken cancellationToken)
        {
            isConsuming = true;
            while (isConsuming)
            {
                try
                {
                    var consumeResult = await Task.Run(() => consumer.Consume(cancellationToken), cancellationToken);
                    if (consumeResult != null && consumeResult.Message != null)
                    {
                        string message = consumeResult.Message.Value;
                        OnMessageReceived?.Invoke(this, new MessageReceivedEventArgs { Message = message });
                    }
                    StopConsuming();

                }
                catch (Exception ex)
                {
                    // construir exceção
                }
            }
        }

        public void StopConsuming()
        {
            isConsuming = false;
            consumer.Close();
        }

        public void Subscribe(string topic, string group)
        {

            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = group,
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = false
            };

            consumer = new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe(topic);
        }
    }
}
