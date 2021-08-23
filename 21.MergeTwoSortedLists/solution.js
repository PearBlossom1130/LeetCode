/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
 var mergeTwoLists = function(l1, l2) {
     if (l1 === null) return l2;
     if (l2 === null) return l1;

     let root = new ListNode();
     let cur = root;

     while(l1 !== null & l2 !== null) {
         if (l1.val < l2.val) {
            cur.next = l1;
            l1 = l1.next
         } else {
             cur.next = l2;
             l2 = l2.next;
         }

         cur = cur.next;
     }

     cur.next = l1 === null ? l2 : l1;

     return root.next;
    
};


 function ListNode(val, next) {
         this.val = (val===undefined ? 0 : val)
         this.next = (next===undefined ? null : next)
     }


let l11 = new ListNode(4)        
let l12 = new ListNode(2,l11)     
let l13 = new ListNode(1,l12)     

let l21 = new ListNode(4)        
let l22 = new ListNode(3,l21)     
let l23 = new ListNode(1,l22)     

mergeTwoLists(l13, l23);
