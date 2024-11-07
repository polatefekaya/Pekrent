"use client";

import { useState, useEffect } from 'react';

// Simulate a delay function
const delay = async (ms: number) => {
  console.log(`Delaying for ${ms} milliseconds`);
  return new Promise((resolve) => {
    setTimeout(() => {
      console.log('Timeout completed');
      resolve(true);
    }, ms);
  });
};

// Custom hook to fetch JSON data
export function useFetchData(url: string) {
  const [data, setData] = useState<any | null>(null);
  const [error, setError] = useState<Error | null>(null);
  const [promise, setPromise] = useState<Promise<any> | null>(null);

  useEffect(() => {
    console.log("useEffect triggered");
    let isSubscribed = true;

    const fetchData = async () => {
      try {
        console.log("Fetching started");
        const loadPromise = delay(2000).then(async () => {
          const response = await fetch(url);
          console.log("Fetch response status:", response.status);
          if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
          }

          const jsonData = await response.json();
          if (isSubscribed) {
            console.log("Response received and data set");
            setData(jsonData);
          }
        });

        setPromise(loadPromise); // Set the promise for Suspense
        await loadPromise; // Wait for the promise to complete
      } catch (error: any) {
        if (isSubscribed) {
          console.error("Error during fetch:", error);
          setError(error);
        }
      }
    };

    fetchData();

    return () => {
      console.log("Cleanup function called, isSubscribed set to false");
      isSubscribed = false;
    };
  }, [url]);

  if (error) {
    console.error("Throwing error from hook");
    throw error; // Let React handle the error with an ErrorBoundary if present
  }

  if (data === null && promise) {
    console.log("Throwing promise for Suspense fallback");
    throw promise; // Throw the actual promise for Suspense
  }

  return data;
}
