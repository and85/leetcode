package com.company;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;

public class Main {

    public static void main(String[] args) {
	// write your code here
        var s = new Solution();
        s.hasGroupsSizeX(new int[] {1,2,3,4,4,3,2,1, 4, 4, 4, 4, 2, 2});
    }

    public static class Solution {
        public boolean hasGroupsSizeX(int[] deck) {
            Map<Integer, Integer> map = new HashMap<Integer, Integer>();
            for (int i = 0; i < deck.length; i++) {
                int key = deck[i];
                if (map.containsKey(key)) {
                    int value = map.get(key);
                    map.put(key, value + 1);
                } else {
                    map.put(key, 1);
                }
            }

            HashSet<Integer> hashSet = new HashSet<Integer>();
            for (var k: map.values()) {
                hashSet.add(k);
            }

            Integer arr[] = new Integer[hashSet.size()];
            hashSet.toArray(arr);

            int gcd = arr[0];

            for (int i = 1; i < arr.length; i++) {
                gcd = FindGreatestCommonDivisor(arr[i], gcd);
            }

            return gcd > 1;
        }

        private int FindGreatestCommonDivisor(int x, int y) {
            int min = Math.min(x, y);
            int max = Math.max(x, y);

            int mod = max % min;
            return ( mod == 0) ? min : FindGreatestCommonDivisor(min, mod);
        }
    }
}
