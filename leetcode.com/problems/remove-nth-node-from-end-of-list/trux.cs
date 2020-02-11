 public ListNode RemoveNthFromEnd(ListNode head, int n) {
            var currentNode = head;
            var nodeCount = 0;
            while (currentNode != null)
            {
                nodeCount ++;
                currentNode = currentNode.next;
            }
            currentNode = head;
            if(n==nodeCount)
            {
                return currentNode.next;
            }
            var temp = 1;
            while (currentNode != null)
            {
                
      
                if(temp == (nodeCount - n))
                {
                    if(n==1)
                    {
                        currentNode.next = null;
                        return head;
                    }
                    currentNode.next = currentNode.next.next;
                }
                temp ++;
                currentNode = currentNode.next;
            }
            return head;
        }