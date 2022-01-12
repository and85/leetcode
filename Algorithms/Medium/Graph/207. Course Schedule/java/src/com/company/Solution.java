package com.company;

import java.util.*;

class Solution {

    public boolean canFinish(int numCourses, int[][] prerequisites) {
        HashMap<Integer, Vertex> vertecies = new HashMap<Integer, Vertex>(numCourses);

        for (int i = 0; i < prerequisites.length; i++) {
            int n = prerequisites[i][0];
            int c = prerequisites[i][1];

            Vertex cource = getVertex(vertecies, c);
            Vertex next = getVertex(vertecies, n);

            cource.Next.add(next);
        }
        
        for (Vertex v: vertecies.values()) {
            if (!canFinish(v)) return false;
        }

        return true;
    }

    private boolean canFinish(Vertex vertex) {

        HashSet<Edge> edges = new HashSet<Edge>();

        Queue<Vertex> queue = new LinkedList<Vertex>();
        queue.add(vertex);

        while (!queue.isEmpty()) {
            Vertex v = queue.poll();
            for (Vertex child: v.Next) {
                Edge e = new Edge(v.Index, child.Index);

                if (edges.contains(e)) return false;
                else edges.add(e);

                queue.add(child);
            }
        }

        return true;
    }

    private Vertex getVertex(HashMap<Integer, Vertex> vertecies, int course) {
        Vertex vc;
        if (vertecies.containsKey(course)) {
            vc = vertecies.get(course);
        }
        else {
            vc = new Vertex(course);
            vc.Next = new ArrayList<Vertex>();
            vertecies.put(course, vc);
        }

        return vc;
    }

    class Vertex {
        public Vertex(int index) {
            Index = index;
        }

        public int Index;
        public ArrayList<Vertex> Next;
    }

    class Edge {
        public int Vertex1;
        public int Vertex2;

        public Edge(int v1, int v2)
        {
            Vertex1 = v1;
            Vertex2 = v2;
        }

        @Override
        public boolean equals(Object o) {

            // null check
            if (o == null) {
                return false;
            }

            // this instance check
            if (this == o) {
                return true;
            }

            if (!(o instanceof Edge)) return false;

            Edge e = (Edge)o;
            return (e.Vertex1 == this.Vertex1 && e.Vertex2 == this.Vertex2) ||
                    (e.Vertex2 == this.Vertex1 && e.Vertex1 == this.Vertex2);
        }

        @Override
        public int hashCode() {
                return Integer.hashCode(Vertex1) ^ Integer.hashCode(Vertex2);
        }
    }

}