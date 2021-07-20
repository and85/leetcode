package com.company;

import java.util.HashMap;

public class Main {

    public static class Solution {
        public boolean checkIfPangram(String sentence) {
            HashMap<Character, Integer> map = new HashMap();
            for (char c = 'a'; c <= 'z'; c++) {
                map.put(c, 0);
            }

            for (char c: sentence.toCharArray()) {
                map.put(c, map.get(c) + 1);
            }

            for (char c = 'a'; c <= 'z'; c++) {
                if (map.get(c) == 0) return false;
            }

            return true;
        }
    }

    public static void main(String[] args) {
	    Solution s = new Solution();
	    s.checkIfPangram("thequickbrownfoxjumpsoverthelazydog");

    }
}
