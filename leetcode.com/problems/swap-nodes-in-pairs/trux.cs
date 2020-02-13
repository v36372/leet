 public ListNode SwapPairs(ListNode head) {
            var currentNode = head;
            while (currentNode != null && currentNode.next != null) { 
            int k = currentNode.data; 
            currentNode.data = currentNode.next.data; 
            currentNode.next.data = k; 
            currentNode = currentNode.next.next; 
            } 
            return head;
}