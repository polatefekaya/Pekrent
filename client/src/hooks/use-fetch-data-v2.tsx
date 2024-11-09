"use client";
import { useState, useEffect } from 'react';

// Cache for storing data and promises
const cache = new Map<string, any>();
const promiseCache = new Map<string, Promise<any>>();

const delay = async (ms: number) => {
  return new Promise((resolve) => setTimeout(resolve, ms));
};

// Prefetch function to start loading data immediately
export const prefetch = async (url: string) => {
  if (promiseCache.has(url)) {
    return promiseCache.get(url);
  }

  const promise = (async () => {
    try {
      await delay(2000);
      const response = await fetch(url);
      
      if (!response.ok) {
        throw new Error(`HTTP error! Status: ${response.status}`);
      }
      
      const jsonData = await response.json();
      cache.set(url, jsonData);
      return jsonData;
    } catch (err) {
      const errorObj = err instanceof Error ? err : new Error('An error occurred');
      throw errorObj;
    }
  })();

  promiseCache.set(url, promise);
  return promise;
};

export function useFetchData(url: string): any | null {
  const [data, setData] = useState<any | null>(() => cache.get(url) || null);
  const [error, setError] = useState<Error | null>(null);

  useEffect(() => {
    let isSubscribed = true;

    const loadData = async () => {
      try {
        // Use the existing promise from prefetch or create a new one
        const promise = promiseCache.get(url) || prefetch(url);
        const result = await promise;
        
        if (isSubscribed) {
          setData(result);
        }
      } catch (err) {
        if (isSubscribed) {
          setError(err instanceof Error ? err : new Error('An error occurred'));
        }
      }
    };

    if (!cache.has(url)) {
      loadData();
    }

    return () => {
      isSubscribed = false;
    };
  }, [url]);

  if (error) {
    throw error;
  }

  if (!data) {
    throw promiseCache.get(url);
  }

  return data;
}