"use client";
import { useState, useEffect } from 'react';

// Simulate a delay function
const delay = async (ms: number) => {
  return new Promise((resolve) => setTimeout(resolve, ms));
};

export function useFetchData(url: string) {
  const [data, setData] = useState<any | null>(null);
  const [error, setError] = useState<Error | null>(null);
  const [promise, setPromise] = useState<Promise<any> | null>(null);

  useEffect(() => {
    let isSubscribed = true;

    const fetchData = async () => {
      // Create a new promise for this fetch operation
      const newPromise = (async () => {
        try {
          await delay(200);
          const response = await fetch(url);
          
          if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
          }
          
          const jsonData = await response.json();
          if (isSubscribed) {
            setData(jsonData);
          }
          return jsonData;
        } catch (err) {
          const errorObj = err instanceof Error ? err : new Error('An error occurred');
          if (isSubscribed) {
            setError(errorObj);
          }
          throw errorObj;
        }
      })();

      setPromise(newPromise);

      try {
        await newPromise;
      } catch (err) {
        // Error is already handled in the promise
      }
    };

    fetchData();

    return () => {
      isSubscribed = false;
    };
  }, [url]);

  if (error) {
    throw error;
  }

  if (!data && promise) {
    throw promise;
  }

  return data;
}