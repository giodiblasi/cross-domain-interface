using System;
using System.Collections.Generic;

namespace CrossDomainInterface{
  /*
   These interfaces define the publisher/subscriber roles.
   Note that "publish" and "subscribe" method are not define in interfaces
   */
  public interface IPublisher{
    string SenderID{get;}
  }

  public interface ISubscriber{
      void OnIncomingMessage(string message);
  }



  /*
  Extension Methods on IPublisher and ISubscriber interfaces
  */
  public static class MessageExtensions {

    /*
    The subscribe method will be added to ISubscribe interface
    */
    public static void Subscribe(this ISubscriber subscriber, string topic){
      MessageManager.RegisterToTopic(subscriber, topic);
    }
    

    /*
    The publish method will be added to IPublish interface
    */
    public static void Publish(this IPublisher loggable, string topic, string message){
      MessageManager
      .GetQueueByTopic(topic)
      .Send(loggable, message);
    }
  }
}