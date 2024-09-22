using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CallCenter
{
    public class CallCente
    {
        public int _counter = 0;
        public Stack<IncommingCall>? Calls{ get; set; }

        public CallCente()
        {
            Calls = new Stack<IncommingCall>();
        }

        public void Call(int clientId, string name) 
        {
            IncommingCall call = new IncommingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                Name = name,
                CallTime = DateTime.Now
            };

            Calls!.Push(call);
        }

        public IncommingCall Answer(string consultant)
        {
            // validação: verificar se tem atendimentos na fila
            if(Calls!.Count > 0) {
                IncommingCall call = Calls.Pop();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }

            return null!;
        }

        public void End(IncommingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls() {
            return (Calls!.Count > 0);
        }
    }
}