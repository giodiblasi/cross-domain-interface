using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossDomainInterface{
  
  /*
  A very simple implementation of a Publisher/Subscriber System 
   */
  public class Topic{
    
    public List<ISubscriber> subscribers= new List<ISubscriber>();
    public string TopicID{get;set;}
    
    public Topic(string topic){
      this.TopicID = topic;
    }

    public void Register(ISubscriber subscriber){
      subscribers.Add(subscriber);
    }

    public void Send(IPublisher sender, string message){
      foreach(var recevers in subscribers.Where(subscriber=>subscriber != sender)) 
        recevers.OnIncomingMessage(string.Format(" From: {1}\n Topic: {0}\n <<{2}>>", TopicID, sender.SenderID, message));
    }
  }

  public static class MessageManager{

    public  const string CODING_TOPIC="CODING";
    public  const string CHEMISTRY_TOPIC="CHEMISTRY";


    private static Dictionary<string,Topic> topics = new Dictionary<string, Topic>{
      {CODING_TOPIC,new Topic(CODING_TOPIC)},
      {CHEMISTRY_TOPIC, new Topic(CHEMISTRY_TOPIC)}
    };

    public static Topic GetQueueByTopic(string topic){
      return topics[topic];
    }
  
    public static void RegisterToTopic(ISubscriber subscriber, string topic){
      topics[topic].Register(subscriber);
    }
  }
}