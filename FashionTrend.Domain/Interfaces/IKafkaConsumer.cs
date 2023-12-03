using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Interfaces
{
    public interface IKafkaConsumer
    {
        event EventHandler<MessageReceivedEventArgs> OnMessageReceived;
        void Subscribe(string topic, string group);
        Task StartConsumingAsync(CancellationToken cancellationToken);
        void StopConsuming();
    }
}
